insert into user values (1,'user01','pass1',1,'Lisa','Admin1');
insert into user values (2,'user02','pass2',2,'Bob','Student1');
insert into user values (3,'user03','pass3',3,'Ann','Teacher1');
insert into administrator values(2,'a1');
select * from administrator;
update administrator set idadministrator=1 where idadministrator=2;
insert into student values(2,current_date(),null);
delete from student where idstudent=2;
select * from teacher;
insert into department values (101,'history');
insert into teacher values (3,100);
insert into course values(200,'C# Basics',5);
insert into course values(201,'SQL Basics',3);
insert into course values(301,'History of Finland',5);idgrade
insert into grade(idstudent,idcourse,idteacher,grade,date) 
values(2,200,3,4,current_date());