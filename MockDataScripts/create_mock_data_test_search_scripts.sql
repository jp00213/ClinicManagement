
  USE "cs6232-g1";
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Lee', 'Allen', '1980-01-01', '123 Street A', 'Los Angeles', 'CA', '91234', '2131234567');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Taylor', 'James', '1990-02-11', '234 Street B', 'Wood city', 'CA', '91111', '2132225555');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Johnson', 'Mary', '1990-03-12', '565 Street C', 'Water city', 'CA', '92222', '6261234545');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Bangloy', 'Susan', '1970-04-16', '25222 Street D', 'Silver city', 'CA', '93333', '6265551214');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Su', 'David', '1981-05-18', '56555 Street E', 'Diamond city', 'CA', '95678', '6264575685');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Williams', 'Thomas', '1982-06-01', '12454 Street F', 'Stone city', 'CA', '90123', '6264547780');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Miller', 'Charles', '1983-07-05', '55521 Street K', 'Sapphire', 'CA', '91231', '6262745121');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Garcia', 'Robert', '1993-08-10', '99 Grand Ave', 'Gold', 'CA', '91222', '9091234567');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Brown', 'John', '1994-10-15', '1002 Main St ', 'Green', 'CA', '91223', '9092228895');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Davis', 'Andy', '2011-11-17', '13001 Amy Rd', 'Blue', 'CA', '91224', '9093338100');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Johnson', 'Billy', '1977-06-19', '184 Hidden st', 'Stone city', 'CA', '90123', '6264588180');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Walker', 'Thomas', '1955-07-27', '51 Huge Ave', 'Sapphire', 'CA', '91231', '6262745441');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Sanchez', 'Louis', '2022-08-18', '39 The Road', 'Gold', 'CA', '91222', '9091235567');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Young', 'Harry', '2021-10-05', '1008 Canyon Rd ', 'Green', 'CA', '98223', '9092228195');
  insert into person (lastName, firstName, birthday, addressStreet, city, state, zip, phoneNumber) values ('Hill', 'Bruce', '2020-11-09', '181 Suzanne Rd ', 'Blue', 'CA', '91284', '9093338166');
  
  
  
  insert into doctor (recordID) values(1);
  insert into doctor (recordID) values(2);
  
  
  insert into account(username, password) values ('nurse001', 'password001');
  insert into account(username, password) values ('nurse002', 'password002');
  insert into account(username, password) values ('nurse003', 'password003');
  
  insert into nurse (username, recordID, activeStatus) values ('nurse001', 3, 1);
  insert into nurse (username, recordID, activeStatus) values ('nurse002', 4, 0);
  insert into nurse (username, recordID, activeStatus) values ('nurse003', 5, 1);
  
  insert into patient (recordID) values (6);
  insert into patient (recordID) values (7);
  insert into patient (recordID) values (8);
  insert into patient (recordID) values (9);
  insert into patient (recordID) values (10);
  insert into patient (recordID) values (11);
  insert into patient (recordID) values (12);
  insert into patient (recordID) values (13);
  insert into patient (recordID) values (14);
  insert into patient (recordID) values (15);
  
  
  
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (1, 1,  '2023-01-05T09:15:00.000', 'sickness' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (2, 2,  '2023-02-05T09:45:00.000', 'sickness' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (3, 2,  '2023-03-06T09:15:00.000', 'sickness' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (4, 2,  '2023-03-06T09:30:00.000', 'fever' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (4, 1,  '2023-01-07T09:15:00.000', 'back pain' ); 
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (4, 1,  '2023-04-05T09:15:00.000', 'fever' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (2, 1,  '2023-04-05T09:45:00.000', 'sickness' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (3, 2,  '2023-04-06T09:15:00.000', 'sickness' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (9, 2,  '2023-04-06T09:30:00.000', 'fever' );
  insert into appointment (patientID, doctorID, appointmentDatetime, reason) values (10, 1, '2023-04-07T09:15:00.000', 'back pain' );