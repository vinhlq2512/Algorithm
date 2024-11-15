/* Write your T-SQL query statement below */

select e.name as Employee from Employee e
    inner join Employee m on e.managerId = m.id and e.salary > m.salary
