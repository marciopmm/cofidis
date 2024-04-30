﻿-- CREDIT LIMIT CALCULATOR - STORED PROCEDURE

CREATE PROC CreditLimitCalc (@MontlyIncome DECIMAL)
AS
  BEGIN
	SELECT 
		CASE
			WHEN @MontlyIncome <= 1000 THEN 1000
			WHEN @MontlyIncome > 1000 AND @MontlyIncome <= 2000 THEN 2000
			ELSE 5000
		END AS Approved
  END
		   