/*Table: Delivery

+-----------------------------+---------+
| Column Name                 | Type    |
+-----------------------------+---------+
| delivery_id                 | int     |
| customer_id                 | int     |
| order_date                  | date    |
| customer_pref_delivery_date | date    |
+-----------------------------+---------+
delivery_id is the column of unique values of this table.
The table holds information about food delivery to customers that make orders at some date and specify a preferred delivery date (on the same order date or after it).
 

If the customer's preferred delivery date is the same as the order date, then the order is called immediate; otherwise, it is called scheduled.

The first order of a customer is the order with the earliest order date that the customer made. It is guaranteed that a customer has precisely one first order.

Write a solution to find the percentage of immediate orders in the first orders of all customers, rounded to 2 decimal places.

The result format is in the following example.

 

Example 1:

Input: 
Delivery table:
+-------------+-------------+------------+-----------------------------+
| delivery_id | customer_id | order_date | customer_pref_delivery_date |
+-------------+-------------+------------+-----------------------------+
| 1           | 1           | 2019-08-01 | 2019-08-02                  |
| 2           | 2           | 2019-08-02 | 2019-08-02                  |
| 3           | 1           | 2019-08-11 | 2019-08-12                  |
| 4           | 3           | 2019-08-24 | 2019-08-24                  |
| 5           | 3           | 2019-08-21 | 2019-08-22                  |
| 6           | 2           | 2019-08-11 | 2019-08-13                  |
| 7           | 4           | 2019-08-09 | 2019-08-09                  |
+-------------+-------------+------------+-----------------------------+
Output: 
+----------------------+
| immediate_percentage |
+----------------------+
| 50.00                |
+----------------------+
Explanation: 
The customer id 1 has a first order with delivery id 1 and it is scheduled.
The customer id 2 has a first order with delivery id 2 and it is immediate.
The customer id 3 has a first order with delivery id 5 and it is scheduled.
The customer id 4 has a first order with delivery id 7 and it is immediate.
Hence, half the customers have immediate first orders.
*/

with FirstOrders as (
    select
        customer_id,
        MIN(order_date) as min_order_date
    from Delivery
    group by customer_id
),
FirstOrderDetails as (
    select D.delivery_id, D.customer_id, D.order_date, D.customer_pref_delivery_date
    from Delivery D
    join FirstOrders F
    on D.customer_id = F.customer_id
    and D.order_date = F.min_order_date
)

Select
    ROUND(100.0*COUNT(case when order_date = customer_pref_delivery_date then 1 else null end) / COUNT(*), 2) as immediate_percentage
from FirstOrderDetails


---------------------------------------------------------------------------------------------------------------------------------------



WITH RankOrder AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY customer_id ORDER BY order_date) AS RowNum
    FROM Delivery    
),
RankOne AS (
    SELECT * 
    FROM RankOrder
    WHERE RowNum = 1
)
SELECT 
    ROUND(SUM(CASE 
                WHEN order_date = customer_pref_delivery_date THEN 100.0 
                ELSE 0 
              END) / COUNT(customer_id), 2) AS immediate_percentage
FROM RankOne;
