/* Write your T-SQL query statement below */

select max(salary) as SecondHighestSalary from Employee e
where salary < (select max(salary) as SecondHighestSalary from Employee e)