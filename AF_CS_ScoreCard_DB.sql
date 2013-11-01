Create TABLE AllScor
( id_all_scores integer unique PRIMARy KEY,
 renting_score integer,
  living_with_parent_score integer,
  owner_with_mortgage_score integer,
  owner_with_no_mortgage_score integer,
  
  single_score integer,
  married_score integer,
  divorced_score integer,
  seperated_score integer,
  
  under_21_score integer,
  between_22_25 integer,
  between_25_30 integer,
  between_30_50 integer,
  over_50 integer,
  
  ccj_true_score integer,
  ccj_false_score integer,
  
  missed_repayment_true integer,
  missed_repayment_false integer,
   
  university_score_tier1 integer,
  university_score_tier2 integer,
  university_score_tier3 integer,
  
  course_applied_score_tier1 integer,
  course_applied_score_tier2 integer,
  course_applied_score_tier3 integer,

  course_1year_score integer,
  course_2years_score integer,
  course_3years_score integer,
  
  part_time_score integer,
  full_time_score integer,
  distance_learning integer,
  course_fees_score_under_10k integer,
  course_fees_score_10_20k integer,
  course_fees_score_20_30k integer,
  course_fees_score_over_30k integer,
  
  place_confirmed_score integer,
  place_not_confirmed integer,

  qualification_0_30_score integer,
  qualification_30_60_score integer,
  qualification_over60 integer,
  
  job_confirmation_score integer,
  job_not_confimed_score integer,
  
  expected_salary_under_15k integer,
  expected_salary_15_25k integer,
  expected_salary_25_50k integer,
  expected_salary_over_50k integer,
  
  grade_AA_score integer,
  grade_A_score integer,
  grade_B_score integer,
  grade_grey_score integer

 
);



 

