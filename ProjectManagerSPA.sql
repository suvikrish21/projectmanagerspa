create database ProjectManagerSPA;

use ProjectManagerSPA;

create table project
(
project_id int identity(1,1),
project varchar(100) NOT NULL,
start_dt DATETIME ,
end_dt DATETIME,
priority int,
constraint pk_project_projectid primary key clustered (project_id)
);

create table parent_task
(
parent_id int identity(1,1),
parent_task varchar(100) NOT NULL,
constraint pk_parenttask_parentid primary key clustered (parent_id)
)

create table task
(
task_id int identity(1,1),
parent_id int,
project_id int,
task varchar(100) NOT NULL,
start_dt DATETIME ,
end_dt DATETIME,
priority int,
status varchar(100) not null,
constraint pk_task_taskid primary key clustered (task_id),
constraint fk_task_projectid foreign key (project_id) references project(project_id),
constraint fk_task_parentid foreign key (parent_id) references parent_task(parent_id)
);


select * from users 
create table users
(
user_id int identity(1,1),
first_name varchar(100) NOT NULL,
last_name varchar(100) NOT NULL,
emp_id int NOT NULL,
project_id int,
task_id int,
constraint pk_user_userid primary key clustered (user_id),
constraint fk_user_projectid foreign key (project_id) references project(project_id),
constraint fk_user_taskid foreign key (task_id) references task(task_id)
);

