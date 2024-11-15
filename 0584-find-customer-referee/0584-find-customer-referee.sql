select name 
from Customer
where isnull(referee_id, ' ') != 2