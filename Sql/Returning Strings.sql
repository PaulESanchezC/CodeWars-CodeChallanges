
--Write a select statement that takes name from person table and return
--"Hello, <name> how are you doing today?" results in a column named greeting
--https://www.codewars.com/kata/55a70521798b14d4750000a4/train/sql
Select CONCAT('Hello, ',name ,' how are you doing today?') as greeting from person;