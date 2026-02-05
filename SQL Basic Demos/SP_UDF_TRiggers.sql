-- builtin functions
-- 	select UPPER('hello world') as UppercaseText

-- 	select LOWER('HELLO WORLD') as LowercaseText
DECLARE @d AS DATE = '08/09/2024';

SELECT FORMAT(@d, 'd', 'en-US') AS 'US English',
       FORMAT(@d, 'd', 'en-gb') AS 'British English',
       FORMAT(@d, 'd', 'de-de') AS 'German',
       FORMAT(@d, 'd', 'zh-cn') AS 'Chinese Simplified (PRC)'


SELECT FORMAT(@d, 'D', 'en-US') AS 'US English',
       FORMAT(@d, 'D', 'en-gb') AS 'British English',
       FORMAT(@d, 'D', 'de-de') AS 'German',
       FORMAT(@d, 'D', 'zh-cn') AS 'Chinese Simplified (PRC)';

       select FORMAT(1234567.89, 'C', 'ma-IN') AS 'Malayalam',
       FORMAT(1234567.89, 'C', 'ta-IN') AS 'Tamil'

       -- display dayname using culture
       declare @d date='2026-02-05'
       select FORMAT(@d, 'dddd', 'ta-IN') AS 'TamilDayname',
       FORMAT(@d, 'dddd', 'ml-IN') AS 'MalayalamDayname'