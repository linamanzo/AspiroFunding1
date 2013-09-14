/*==============================================================*/
/* Nom de SGBD :  PostgreSQL 8                                  */
/* Date de création :  27/08/2013 13:48:21                      */
/*==============================================================*/


drop table Bid;

drop table Borrowers;

drop table CanSuscribeTo;

drop table Course;

drop table CourseDetails;

drop table CreditScore;

drop table Dates;

drop table FinancialDetails;

drop table JobHistory;

drop table JobProspect;

drop table Lenders;

drop table Matched;

drop table News;

drop table Newsletter;

drop table Offer;

drop table PersonnalDetails;

drop table PostgraduateCourse;

drop table PostgraduateUni;

drop table UndergraduateCourse;

drop table UndergraduateUni;

drop table University;

drop table Users;

/*==============================================================*/
/* Table : Bid                                                  */
/*==============================================================*/
create table Bid (
   idBid                INT4                 not null,
   loanStart            DATE                 null,
   bidAmountOriginal    INT4                 null,
   bidAmount            INT4                 null,
   interestRate         INT4                 null,
   constraint PK_BID primary key (idBid)
);

/*==============================================================*/
/* Table : Borrowers                                            */
/*==============================================================*/
create table Borrowers (
   idBorrower           INT4                 not null,
   iDundUni             INT4                 not null,
   underUniName         VARCHAR(254)         not null,
   iDpostUni            INT4                 not null,
   posUniName           VARCHAR(254)         not null,
   IDUni                INT4                 not null,
   IDpostCourse         INT4                 not null,
   postCourseName       VARCHAR(254)         not null,
   IDundCourse          INT4                 not null,
   courseName           VARCHAR(254)         not null,
   IDCourse             INT4                 not null,
   idBid                INT4                 not null,
   idUser               INT4                 not null,
   email                VARCHAR(254)         not null,
   iDcreditscore        INT4                 not null,
   grade                VARCHAR(254)         not null,
   postgraduateEndDate  DATE                 not null,
   postgraduateConfirmed BOOL                 not null,
   undergraduateGrade   VARCHAR(254)         not null,
   borrowerProfile      text                 not null,
   constraint PK_BORROWERS primary key (idBorrower)
);

/*==============================================================*/
/* Table : CanSuscribeTo                                        */
/*==============================================================*/
create table CanSuscribeTo (
   idNewsletter         INT4                 not null,
   idUser               INT4                 not null,
   email                VARCHAR(254)         not null,
   constraint PK_CANSUSCRIBETO primary key (idNewsletter, idUser, email)
);

/*==============================================================*/
/* Table : Course                                               */
/*==============================================================*/
create table Course (
   IDpostCourse         INT4                 not null,
   postCourseName       VARCHAR(254)         not null,
   IDundCourse          INT4                 not null,
   courseName           VARCHAR(254)         not null,
   IDCourse             INT4                 not null,
   constraint PK_COURSE primary key (IDpostCourse, postCourseName, IDundCourse, courseName, IDCourse)
);

/*==============================================================*/
/* Table : CourseDetails                                        */
/*==============================================================*/
create table CourseDetails (
   iDcd                 INT4                 not null,
   courseDuration       INT4                 not null,
   "part/FullTime"      VARCHAR(254)         not null,
   courseFees           INT4                 not null,
   placeConfirmed       BOOL                 not null,
   courseTier           INT4                 not null,
   uniTier              INT4                 not null,
   courseScore          INT4                 not null,
   constraint PK_COURSEDETAILS primary key (iDcd, courseScore)
);

/*==============================================================*/
/* Table : CreditScore                                          */
/*==============================================================*/
create table CreditScore (
   score                INT4                 not null,
   grade                VARCHAR(254)         not null,
   comment              VARCHAR(254)         null,
   iDcreditscore        INT4                 not null,
   prospectScore        INT4                 not null,
   iDjp                 INT4                 not null,
   iDjh                 INT4                 not null,
   jobHistoryScore      INT4                 not null,
   iDcd                 INT4                 not null,
   courseScore          INT4                 not null,
   personnalScore       INT4                 not null,
   iDpersD              INT4                 not null,
   financialScore       INT4                 not null,
   iDfd                 INT4                 not null,
   constraint PK_CREDITSCORE primary key (iDcreditscore, grade)
);

/*==============================================================*/
/* Table : Dates                                                */
/*==============================================================*/
create table Dates (
   createdAt            DATE                 null,
   updatedAt            DATE                 null
);

/*==============================================================*/
/* Table : FinancialDetails                                     */
/*==============================================================*/
create table FinancialDetails (
   iDfd                 INT4                 not null,
   ccj                  INT4                 not null,
   missedRepayment      INT4                 not null,
   loanOutstanding      INT4                 not null,
   existingCreditCard   INT4                 null,
   financialScore       INT4                 not null,
   constraint PK_FINANCIALDETAILS primary key (financialScore, iDfd)
);

/*==============================================================*/
/* Table : JobHistory                                           */
/*==============================================================*/
create table JobHistory (
   previouslyEmployed   VARCHAR(254)         not null,
   previousSalary       INT4                 not null,
   jobDuration          INT4                 not null,
   jobHistoryScore      INT4                 not null,
   iDjh                 INT4                 not null,
   constraint PK_JOBHISTORY primary key (iDjh, jobHistoryScore)
);

/*==============================================================*/
/* Table : JobProspect                                          */
/*==============================================================*/
create table JobProspect (
   iDjp                 INT4                 not null,
   jobConfirmed         BOOL                 not null,
   expectedSalary       INT4                 not null,
   prospectScore        INT4                 not null,
   constraint PK_JOBPROSPECT primary key (prospectScore, iDjp),
   constraint AK_IDENTIFIANT_1_JOBPROSP unique (iDjp)
);

/*==============================================================*/
/* Table : Lenders                                              */
/*==============================================================*/
create table Lenders (
   idLender             INT4                 not null,
   idUser               INT4                 not null,
   email                VARCHAR(254)         not null,
   alumniUnivesrsity    VARCHAR(254)         null,
   lenderProfile        text                 null,
   constraint PK_LENDERS primary key (idLender)
);

/*==============================================================*/
/* Table : Matched                                              */
/*==============================================================*/
create table Matched (
   idOffer              INT4                 not null,
   idBid                INT4                 not null,
   idMatch              INT4                 not null,
   constraint PK_MATCHED primary key (idOffer, idBid, idMatch)
);

/*==============================================================*/
/* Table : News                                                 */
/*==============================================================*/
create table News (
   idNews               INT4                 not null,
   headline             VARCHAR(254)         null,
   summary              VARCHAR(254)         null,
   story                text                 null,
   constraint PK_NEWS primary key (idNews)
);

/*==============================================================*/
/* Table : Newsletter                                           */
/*==============================================================*/
create table Newsletter (
   idNewsletter         INT4                 not null,
   constraint PK_NEWSLETTER primary key (idNewsletter)
);

/*==============================================================*/
/* Table : Offer                                                */
/*==============================================================*/
create table Offer (
   idOffer              INT4                 not null,
   idLender             INT4                 not null,
   startDate            DATE                 null,
   offerAmountOriginal  INT4                 null,
   offerAmount          INT4                 null,
   rate                 INT4                 null,
   constraint PK_OFFER primary key (idOffer)
);

/*==============================================================*/
/* Table : PersonnalDetails                                     */
/*==============================================================*/
create table PersonnalDetails (
   iDpersD              INT4                 not null,
   age                  INT4                 not null,
   maritalStatus        VARCHAR(254)         not null,
   residentialStatus    VARCHAR(254)         not null,
   personnalScore       INT4                 not null,
   constraint PK_PERSONNALDETAILS primary key (personnalScore, iDpersD)
);

/*==============================================================*/
/* Table : PostgraduateCourse                                   */
/*==============================================================*/
create table PostgraduateCourse (
   IDpostCourse         INT4                 not null,
   postCourseName       VARCHAR(254)         not null,
   PostCourseTier       INT4                 null,
   constraint PK_POSTGRADUATECOURSE primary key (IDpostCourse, postCourseName)
);

/*==============================================================*/
/* Table : PostgraduateUni                                      */
/*==============================================================*/
create table PostgraduateUni (
   iDpostUni            INT4                 not null,
   posUniName           VARCHAR(254)         not null,
   PosUniTier           INT4                 null,
   constraint PK_POSTGRADUATEUNI primary key (iDpostUni, posUniName)
);

/*==============================================================*/
/* Table : UndergraduateCourse                                  */
/*==============================================================*/
create table UndergraduateCourse (
   IDundCourse          INT4                 not null,
   courseName           VARCHAR(254)         not null,
   UnderCourseTier      INT4                 null,
   constraint PK_UNDERGRADUATECOURSE primary key (IDundCourse, courseName)
);

/*==============================================================*/
/* Table : UndergraduateUni                                     */
/*==============================================================*/
create table UndergraduateUni (
   iDundUni             INT4                 not null,
   underUniName         VARCHAR(254)         not null,
   UndUniTier           INT4                 null,
   constraint PK_UNDERGRADUATEUNI primary key (iDundUni, underUniName)
);

/*==============================================================*/
/* Table : University                                           */
/*==============================================================*/
create table University (
   iDundUni             INT4                 not null,
   underUniName         VARCHAR(254)         not null,
   iDpostUni            INT4                 not null,
   posUniName           VARCHAR(254)         not null,
   IDUni                INT4                 not null,
   constraint PK_UNIVERSITY primary key (iDundUni, underUniName, iDpostUni, posUniName, IDUni)
);

/*==============================================================*/
/* Table : Users                                                */
/*==============================================================*/
create table Users (
   idUser               INT4                 not null,
   username             VARCHAR(254)         null,
   firstName            VARCHAR(254)         null,
   lastName             VARCHAR(254)         null,
   email                VARCHAR(254)         not null,
   hashed_password      VARCHAR(254)         null,
   salt                 VARCHAR(254)         null,
   type                 VARCHAR(254)         null,
   admin                BOOL                 null,
   constraint PK_USERS primary key (idUser, email)
);

alter table Borrowers
   add constraint FK_BORROWER_ARE_USERS foreign key (idUser, email)
      references Users (idUser, email)
      on delete restrict on update restrict;

alter table Borrowers
   add constraint FK_BORROWER_CREDITSCO_CREDITSC foreign key (iDcreditscore, grade)
      references CreditScore (iDcreditscore, grade)
      on delete restrict on update restrict;

alter table Borrowers
   add constraint FK_BORROWER_EDUCINFOS_UNIVERSI foreign key (iDundUni, underUniName, iDpostUni, posUniName, IDUni)
      references University (iDundUni, underUniName, iDpostUni, posUniName, IDUni)
      on delete restrict on update restrict;

alter table Borrowers
   add constraint FK_BORROWER_SUSCRIBET_BID foreign key (idBid)
      references Bid (idBid)
      on delete restrict on update restrict;

alter table Borrowers
   add constraint FK_BORROWER_UNDERTAKE_COURSE foreign key (IDpostCourse, postCourseName, IDundCourse, courseName, IDCourse)
      references Course (IDpostCourse, postCourseName, IDundCourse, courseName, IDCourse)
      on delete restrict on update restrict;

alter table CanSuscribeTo
   add constraint FK_CANSUSCR_CANSUSCRI_NEWSLETT foreign key (idNewsletter)
      references Newsletter (idNewsletter)
      on delete restrict on update restrict;

alter table CanSuscribeTo
   add constraint FK_CANSUSCR_CANSUSCRI_USERS foreign key (idUser, email)
      references Users (idUser, email)
      on delete restrict on update restrict;

alter table Course
   add constraint FK_COURSE_COURSEUND_UNDERGRA foreign key (IDundCourse, courseName)
      references UndergraduateCourse (IDundCourse, courseName)
      on delete restrict on update restrict;

alter table Course
   add constraint FK_COURSE_POSGRADCO_POSTGRAD foreign key (IDpostCourse, postCourseName)
      references PostgraduateCourse (IDpostCourse, postCourseName)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_CDSCORES_COURSEDE foreign key (iDcd, courseScore)
      references CourseDetails (iDcd, courseScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_FDSCORES_FINANCIA foreign key (financialScore, iDfd)
      references FinancialDetails (financialScore, iDfd)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_JHSCORES_JOBHISTO foreign key (iDjh, jobHistoryScore)
      references JobHistory (iDjh, jobHistoryScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_JPSCORES_JOBPROSP foreign key (prospectScore, iDjp)
      references JobProspect (prospectScore, iDjp)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_PERSDSCOR_PERSONNA foreign key (personnalScore, iDpersD)
      references PersonnalDetails (personnalScore, iDpersD)
      on delete restrict on update restrict;

alter table Lenders
   add constraint FK_LENDERS_ARE_USERS foreign key (idUser, email)
      references Users (idUser, email)
      on delete restrict on update restrict;

alter table Matched
   add constraint FK_MATCHED_MATCHED_BID foreign key (idBid)
      references Bid (idBid)
      on delete restrict on update restrict;

alter table Matched
   add constraint FK_MATCHED_MATCHED_OFFER foreign key (idOffer)
      references Offer (idOffer)
      on delete restrict on update restrict;

alter table Offer
   add constraint FK_OFFER_ACCEPT_LENDERS foreign key (idLender)
      references Lenders (idLender)
      on delete restrict on update restrict;

alter table University
   add constraint FK_UNIVERSI_POSTGRADU_POSTGRAD foreign key (iDpostUni, posUniName)
      references PostgraduateUni (iDpostUni, posUniName)
      on delete restrict on update restrict;

alter table University
   add constraint FK_UNIVERSI_UNDERGRAD_UNDERGRA foreign key (iDundUni, underUniName)
      references UndergraduateUni (iDundUni, underUniName)
      on delete restrict on update restrict;

