/*==============================================================*/
/* Nom de SGBD :  PostgreSQL 8                                  */
/* Date de création :  20/09/2013 16:29:38                      */
/*==============================================================*/


drop table Bid;

drop table Borrowers;

drop table Course;

drop table CourseDetails;

drop table CourseScores;

drop table CreditScore;

drop table FinancialDetails;

drop table JobHistory;

drop table JobProspect;

drop table Lenders;

drop table Matched;

drop table Offer;

drop table PersonnalDetails;

drop table UniScores;

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
   idBid                INT4                 not null,
   idUser               INT4                 not null,
   postgraduateEndDate  DATE                 null,
   postgraduateConfirmed BOOL                 null,
   undergraduateGrade   VARCHAR(254)         null,
   borrowerProfile      text                 null,
   constraint PK_BORROWERS primary key (idBorrower)
);

/*==============================================================*/
/* Table : Course                                               */
/*==============================================================*/
create table Course (
   IDCourse             INT4                 not null,
   courseTier           INT4                 not null,
   courseName           INT4                 not null,
   constraint PK_COURSE primary key (IDCourse)
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
   courseScore          INT4                 not null,
   iDcreditscore        INT4                 null,
   idUser               INT4                 null,
   constraint PK_COURSEDETAILS primary key (courseScore)
);

/*==============================================================*/
/* Table : CourseScores                                         */
/*==============================================================*/
create table CourseScores (
   iDcreditscore        INT4                 not null,
   idUser               INT4                 not null,
   IDCourse             INT4                 not null,
   constraint PK_COURSESCORES primary key (iDcreditscore, idUser, IDCourse)
);

/*==============================================================*/
/* Table : CreditScore                                          */
/*==============================================================*/
create table CreditScore (
   iDcreditscore        INT4                 not null,
   financialScore       INT4                 null,
   personnalScore       INT4                 null,
   courseScore          INT4                 null,
   jobHistoryScore      INT4                 null,
   prospectScore        INT4                 null,
   Uniscore             INT4                 null,
   idUser               INT4                 not null,
   score                INT4                 not null,
   grade                VARCHAR(254)         not null,
   comment              VARCHAR(254)         null,
   constraint PK_CREDITSCORE primary key (iDcreditscore, idUser)
);

/*==============================================================*/
/* Table : FinancialDetails                                     */
/*==============================================================*/
create table FinancialDetails (
   iDfd                 INT4                 not null,
   ccj                  BOOL                 not null,
   missedRepayment      BOOL                 not null,
   loanOutstanding      INT4                 null,
   existingCreditCard   INT4                 null,
   financialScore       INT4                 not null,
   iDcreditscore        INT4                 not null,
   idUser               INT4                 not null,
   constraint PK_FINANCIALDETAILS primary key (financialScore)
);

/*==============================================================*/
/* Table : JobHistory                                           */
/*==============================================================*/
create table JobHistory (
   iDjh                 INT4                 not null,
   previouslyEmployed   VARCHAR(254)         null,
   previousSalary       INT4                 null,
   jobDuration          INT4                 null,
   jobHistoryScore      INT4                 not null,
   iDcreditscore        INT4                 null,
   idUser               INT4                 null,
   constraint PK_JOBHISTORY primary key (jobHistoryScore)
);

/*==============================================================*/
/* Table : JobProspect                                          */
/*==============================================================*/
create table JobProspect (
   iDjp                 INT4                 not null,
   jobConfirmed         BOOL                 not null,
   expectedSalary       INT4                 null,
   prospectScore        INT4                 not null,
   iDcreditscore        INT4                 null,
   idUser               INT4                 null,
   constraint PK_JOBPROSPECT primary key (prospectScore)
);

/*==============================================================*/
/* Table : Lenders                                              */
/*==============================================================*/
create table Lenders (
   idLender             INT4                 not null,
   idUser               INT4                 not null,
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
   iDcreditscore        INT4                 null,
   idUser               INT4                 null,
   constraint PK_PERSONNALDETAILS primary key (personnalScore)
);

/*==============================================================*/
/* Table : UniScores                                            */
/*==============================================================*/
create table UniScores (
   iDcreditscore        INT4                 not null,
   idUser               INT4                 not null,
   IDUni                INT4                 null,
   Uniscore             INT4                 not null,
   constraint PK_UNISCORES primary key (Uniscore)
);

/*==============================================================*/
/* Table : University                                           */
/*==============================================================*/
create table University (
   IDUni                INT4                 not null,
   uniTier              INT4                 not null,
   uniName              INT4                 not null,
   Uniscore             INT4                 not null,
   constraint PK_UNIVERSITY primary key (IDUni, Uniscore)
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
   constraint PK_USERS primary key (idUser)
);

alter table Borrowers
   add constraint FK_BORROWER_ARE_USERS foreign key (idUser)
      references Users (idUser)
      on delete restrict on update restrict;

alter table Borrowers
   add constraint FK_BORROWER_SUSCRIBET_BID foreign key (idBid)
      references Bid (idBid)
      on delete restrict on update restrict;

alter table CourseDetails
   add constraint FK_COURSEDE_CDSCORES_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table CourseScores
   add constraint FK_COURSESC_COURSESCO_COURSE foreign key (IDCourse)
      references Course (IDCourse)
      on delete restrict on update restrict;

alter table CourseScores
   add constraint FK_COURSESC_COURSESCO_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_CDSCORES_COURSEDE foreign key (courseScore)
      references CourseDetails (courseScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_CREDITSCO_USERS foreign key (idUser)
      references Users (idUser)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_FDSCORES_FINANCIA foreign key (financialScore)
      references FinancialDetails (financialScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_JHSCORES_JOBHISTO foreign key (jobHistoryScore)
      references JobHistory (jobHistoryScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_JPSCORES_JOBPROSP foreign key (prospectScore)
      references JobProspect (prospectScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_PERSDSCOR_PERSONNA foreign key (personnalScore)
      references PersonnalDetails (personnalScore)
      on delete restrict on update restrict;

alter table CreditScore
   add constraint FK_CREDITSC_REFERENCE_UNISCORE foreign key (Uniscore)
      references UniScores (Uniscore)
      on delete restrict on update restrict;

alter table FinancialDetails
   add constraint FK_FINANCIA_FDSCORES_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table JobHistory
   add constraint FK_JOBHISTO_JHSCORES_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table JobProspect
   add constraint FK_JOBPROSP_JPSCORES_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table Lenders
   add constraint FK_LENDERS_ARE_USERS foreign key (idUser)
      references Users (idUser)
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

alter table PersonnalDetails
   add constraint FK_PERSONNA_PERSDSCOR_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table UniScores
   add constraint FK_UNISCORE_UNISCORES_CREDITSC foreign key (iDcreditscore, idUser)
      references CreditScore (iDcreditscore, idUser)
      on delete restrict on update restrict;

alter table UniScores
   add constraint FK_UNISCORE_UNISCORES_UNIVERSI foreign key (IDUni, Uniscore)
      references University (IDUni, Uniscore)
      on delete restrict on update restrict;

