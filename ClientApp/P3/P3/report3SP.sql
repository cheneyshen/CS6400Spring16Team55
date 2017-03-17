DELIMITER $$
CREATE DEFINER=`team55`@`%` PROCEDURE `report3_proc`()
BEGIN

CREATE TEMPORARY TABLE temp1 as (
	select Reservation_ID,
	to_days(end_date) - to_days(start_date) + 1 as duration
	from reservation
	where start_date between LAST_DAY(NOW() - INTERVAL 1 MONTH) and LAST_DAY(NOW())
	and end_date between LAST_DAY(NOW() - INTERVAL 1 MONTH) and LAST_DAY(NOW())
	and end_date > start_date 
    );

insert INTO temp1
	select Reservation_ID,
	to_days(end_date) - to_days(LAST_DAY(NOW())) as
	duration
	from reservation
	where start_date <= LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and end_date between LAST_DAY(NOW() - INTERVAL 1 MONTH) and LAST_DAY(NOW());

insert INTO temp1
	select Reservation_ID,
	to_days(LAST_DAY(NOW())) - to_days(start_date) + 1 as duration
	from reservation
	where end_date > LAST_DAY(NOW())
	and start_date between LAST_DAY(NOW() - INTERVAL 1 MONTH) and LAST_DAY(NOW());

insert INTO temp1
	select Reservation_ID,
	to_days(LAST_DAY(NOW())) - to_days(LAST_DAY(NOW() - INTERVAL 1
	MONTH)) as duration
	from reservation
	where start_date <= LAST_DAY(NOW() - INTERVAL 1 MONTH)
	and end_date > LAST_DAY(NOW());

#select * from temp1;

CREATE TEMPORARY TABLE temp2 as (
	Select reservation.clerk_id_pickup,
	ifnull(count(temp1.Reservation_ID), 0) as pickcount
	from temp1, reservation
	Where temp1.Reservation_ID = reservation.Reservation_ID
	And reservation.clerk_id_pickup is not null
	Group by reservation.clerk_id_pickup
	);

#select * from temp2;

CREATE TEMPORARY TABLE temp3 as (
	Select reservation.clerk_id_dropoff,
	ifnull(count(temp1.Reservation_ID), 0) as dropcount
	from temp1, reservation
	Where temp1.Reservation_ID = reservation.Reservation_ID
	And reservation.clerk_id_dropoff is not null
	Group by reservation.clerk_id_dropoff
	);

#select * from temp3;

Select 
	clerk.first_name, 
	clerk.last_name,
    IFNULL(temp2.pickcount, 0) as pickcount,
    IFNULL(temp3.dropcount, 0) as dropcount, 
    IFNULL(temp2.pickcount, 0) + IFNULL(temp3.dropcount, 0) as totalcount  
From clerk
	Left JOIN temp2 on temp2.clerk_id_pickup = clerk.Clerk_ID
	Left join temp3 on temp3.clerk_id_dropoff = clerk.Clerk_ID;
    
drop table temp1;
drop table temp2;
drop table temp3;

END$$
DELIMITER ;
