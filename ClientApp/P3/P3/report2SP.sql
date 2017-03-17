CREATE DEFINER=`team55`@`%` PROCEDURE `report2_proc`()
BEGIN
# get reservations which first date of last month <= start_date < end_date<= last date of last month
CREATE TEMPORARY TABLE temp1 as (
	select Reservation_ID,Email,
	to_days(end_date) - to_days(start_date) + 1 as duration
	from reservation
	where start_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and end_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and end_date > start_date
);
# get reservations which start_date < first date of last month < end_date<= last date of last month
insert INTO temp1
	select Reservation_ID,Email,
	to_days(end_date) - to_days(LAST_DAY(NOW() - INTERVAL 2 MONTH)) as
	duration
	from reservation
	where start_date <= LAST_DAY(NOW() - INTERVAL 2 MONTH)
	and end_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH)
;
# get reservations which first date of last month <= start_date < last date of last month < end_date
insert INTO temp1
	select Reservation_ID,Email,
	to_days(LAST_DAY(NOW() - INTERVAL 1 MONTH))- to_days(start_date) +
	1 as duration
	from reservation
	where end_date > LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and start_date between LAST_DAY(NOW() - INTERVAL 2 MONTH) and LAST_DAY(NOW() - INTERVAL 1 MONTH)
;
# get reservations which start_date < first date of last month < last date of last month < end_date
insert INTO temp1
	select Reservation_ID,Email,
	to_days(LAST_DAY(NOW() - INTERVAL 1 MONTH)) -
	to_days(LAST_DAY(NOW() - INTERVAL 2 MONTH)) as duration
	from reservation
	where start_date <= LAST_DAY(NOW() - INTERVAL 2 MONTH)
	and end_date > LAST_DAY(NOW() - INTERVAL 1 MONTH)
;
# get every customer and number of rentals
SELECT
    temp1.Email,
    customer.first_name,
    customer.last_name,
    customer.address,
    COUNT(temp1.Reservation_ID) AS ordercounts
FROM
    temp1,
    customer
WHERE temp1.Email = customer.Email
GROUP BY temp1.Email
ORDER BY ordercounts DESC , customer.last_name DESC
;
# remove temp table
drop table temp1;
END