select age, count(*) as total_people
from people
group by age
having count(*) > 9