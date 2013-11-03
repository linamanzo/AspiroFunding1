--
-- PostgreSQL database dump
--

-- Dumped from database version 9.2.4
-- Dumped by pg_dump version 9.2.4
-- Started on 2013-11-03 15:45:06

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

SET search_path = public, pg_catalog;

--
-- TOC entry 2020 (class 0 OID 1139258)
-- Dependencies: 180
-- Data for Name: allscor; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY allscor (id_all_scores, renting_score, living_with_parent_score, owner_with_mortgage_score, owner_with_no_mortgage_score, single_score, married_score, divorced_score, seperated_score, under_21_score, between_22_25, between_25_30, between_30_50, over_50, ccj_true_score, ccj_false_score, missed_repayment_true, missed_repayment_false, university_score_tier1, university_score_tier2, university_score_tier3, course_applied_score_tier1, course_applied_score_tier2, course_applied_score_tier3, course_1year_score, course_2years_score, course_3years_score, part_time_score, full_time_score, distance_learning, course_fees_score_under_10k, course_fees_score_10_20k, course_fees_score_20_30k, course_fees_score_over_30k, place_confirmed_score, place_not_confirmed, qualification_0_30_score, qualification_30_60_score, qualification_over60, job_confirmation_score, job_not_confimed_score, expected_salary_under_15k, expected_salary_15_25k, expected_salary_25_50k, expected_salary_over_50k, grade_aa_score, grade_a_score, grade_b_score, grade_grey_score) FROM stdin;
1	10	20	10	40	10	30	0	10	0	5	20	10	0	-999	0	-999	0	50	20	10	50	20	10	30	30	10	20	30	10	20	30	10	0	0	-999	-999	30	60	30	0	0	10	30	40	300	250	200	150
\.


--
-- TOC entry 2008 (class 0 OID 401952)
-- Dependencies: 168
-- Data for Name: borrowers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY borrowers (idborrower, idbid, iduser, postgraduateenddate, postgraduateconfirmed, undergraduategrade, borrowerprofile) FROM stdin;
\.


--
-- TOC entry 2009 (class 0 OID 401960)
-- Dependencies: 169
-- Data for Name: course; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY course (idcourse, coursetier, coursename) FROM stdin;
1	1	1
\.


--
-- TOC entry 2010 (class 0 OID 401965)
-- Dependencies: 170
-- Data for Name: coursedetails; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY coursedetails (idcd, courseduration, "part/FullTime", coursefees, placeconfirmed, coursescore, idcreditscore, iduser) FROM stdin;
1	6	full time	10000	f	30	12	1
\.


--
-- TOC entry 2011 (class 0 OID 401970)
-- Dependencies: 171
-- Data for Name: coursescores; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY coursescores (idcreditscore, iduser, idcourse) FROM stdin;
\.


--
-- TOC entry 2012 (class 0 OID 401975)
-- Dependencies: 172
-- Data for Name: creditscore; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY creditscore (idcreditscore, financialscore, personnalscore, coursescore, jobhistoryscore, prospectscore, uniscore, iduser, score, grade, comment) FROM stdin;
12	50	30	\N	\N	\N	\N	1	150	A	ok
\.


--
-- TOC entry 2013 (class 0 OID 401983)
-- Dependencies: 173
-- Data for Name: financialdetails; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY financialdetails (idfd, ccj, missedrepayment, loanoutstanding, existingcreditcard, financialscore, idcreditscore, iduser) FROM stdin;
1	f	f	0	0	50	12	1
\.


--
-- TOC entry 2014 (class 0 OID 401988)
-- Dependencies: 174
-- Data for Name: jobhistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY jobhistory (idjh, previouslyemployed, previoussalary, jobduration, jobhistoryscore, idcreditscore, iduser) FROM stdin;
1	yes	25000	6	1	\N	1
\.


--
-- TOC entry 2015 (class 0 OID 401993)
-- Dependencies: 175
-- Data for Name: jobprospect; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY jobprospect (idjp, jobconfirmed, expectedsalary, prospectscore, idcreditscore, iduser) FROM stdin;
1	t	25000	10	\N	1
\.


--
-- TOC entry 2019 (class 0 OID 549369)
-- Dependencies: 179
-- Data for Name: personnaldetails; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY personnaldetails (idpersd, age, maritalstatus, residentialstatus, personnalscore, idcreditscore, iduser) FROM stdin;
1	20	single	renting	30	12	1
\.


--
-- TOC entry 2016 (class 0 OID 402006)
-- Dependencies: 176
-- Data for Name: uniscores; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY uniscores (idcreditscore, iduser, iduni, uniscore) FROM stdin;
\.


--
-- TOC entry 2017 (class 0 OID 402011)
-- Dependencies: 177
-- Data for Name: university; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY university (iduni, unitier, uniname, uniscore) FROM stdin;
\.


--
-- TOC entry 2018 (class 0 OID 402016)
-- Dependencies: 178
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY users (iduser, username, firstname, lastname, email, hashed_password, salt, type, admin) FROM stdin;
1	firstuser	customer	one	one.customer@hotmail.com	custom	\N	\N	f
\.


-- Completed on 2013-11-03 15:45:07

--
-- PostgreSQL database dump complete
--

