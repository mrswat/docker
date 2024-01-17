create table DockerImage
(
   Id serial primary key,
   Name varchar(512)
);

insert into DockerImage(Name) values ('PostgreSql'),('Nginx'),('Redis')