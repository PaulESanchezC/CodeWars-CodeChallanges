/*https://www.codewars.com/kata/594804a218e96caa8d00051b/train/sql
Given a demographics table in the following format:

** demographics table schema **
id, name, birthday, race

you need to return the same table where all text fields (name & race) are changed to the ascii code of their first byte.
e.g. Verlie = 86 Warren = 87 Horace = 72 Tracy = 84
SQL  */

select 
id,
ascii(name) as name,
birthday,
ascii(race) as race
from demographics 