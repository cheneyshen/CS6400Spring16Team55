DELIMITER $$
CREATE DEFINER=`team55`@`%` PROCEDURE `report1_proc`()
BEGIN

# get reservations which first date of last month <= start_date < end_date<= last date of last month
CREATE TEMPORARY TABLE temp1 as (
	select Reservation_ID,
	TO_DAYS(end_date) - TO_DAYS(start_date) + 1 as duration
	from reservation
	where start_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and end_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and end_date > start_date);

# get reservations which start_date < first date of last month < end_date<= last date of last month
insert INTO temp1
	select Reservation_ID,
	to_days(end_date) - to_days(LAST_DAY(NOW() - INTERVAL 2 MONTH)) as duration
	from reservation
	where start_date <= LAST_DAY(NOW() - INTERVAL 2 MONTH)
	and end_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH);

# get reservations which first date of last month <= start_date < last date of last month < end_date
insert INTO temp1
	select Reservation_ID,
	to_days(LAST_DAY(NOW() - INTERVAL 1 MONTH))-to_days(start_date) + 1 as duration
	from reservation
	where end_date > LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and start_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH);

# get reservations which start_date < first date of last month < last date of last month < end_date
insert INTO temp1
	select Reservation_ID,
	to_days(LAST_DAY(NOW() - INTERVAL 1 MONTH)) - to_days(LAST_DAY(NOW() - INTERVAL 2 MONTH)) as duration
	from reservation
	where start_date <= LAST_DAY(NOW() - INTERVAL 2 MONTH)
	and end_date > LAST_DAY(NOW() - INTERVAL 1 MONTH);

#select * from temp1;

# get tool id, description, orig_purchase_price, profit from these reservations
CREATE TEMPORARY TABLE temp2 as (
	Select t.Tool_ID, 
		t.abbr_description,
		t.orig_purchase_price, 
        (CASE  
			WHEN t.rent_cost * te.duration > 0 THEN t.rent_cost * te.duration 
			ELSE 0
		END) AS profit 
	From temp1 te
    INNER join reservationtool rt on rt.reservation_id = te.Reservation_ID
    RIGHT join tool t on t.Tool_ID = rt.Tool_ID
	Where t.on_sale = 0
	Group by t.Tool_ID);

#select * from temp2;

# get tool repair cost from serviceorder
CREATE TEMPORARY TABLE temp3 as (
	Select Tool_ID, sum(est_repair_cost) as cost1
	from serviceorder group by Tool_ID);

#select * from temp3;

# get total cost of the tool from temp2, temp3
CREATE TEMPORARY TABLE temp4 as (
	Select 
		t.Tool_ID, 
        (CASE  
			WHEN temp3.cost1 > 0 THEN (t.orig_purchase_price + temp3.cost1)  
			ELSE t.orig_purchase_price
		END) AS cost,
        temp3.cost1,
        t.orig_purchase_price
	from temp3
    RIGHT join temp2 t on t.Tool_ID = temp3.Tool_ID);
    
#select * from temp4;

# output tool id, abbrdesc, totalprofit, cost, profit;
Select temp2.Tool_ID, 
	temp2.abbr_description,
	temp2.profit - temp4.cost as totalprofit,
	temp4.cost, 
	temp2.profit
	From temp2, temp4 
	where temp2.Tool_ID = temp4.Tool_ID
	Order by totalprofit desc;

# remove temp tables
drop table temp1; 
drop table temp2; 
drop table temp3; 
drop table temp4; 

END$$
DELIMITER ;
