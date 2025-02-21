/* Write your T-SQL query statement below */
SELECT MAX(salary) 
AS SecondHighestSalary 
from Employee 
where salary<(SELECT MAX(salary) from Employee);