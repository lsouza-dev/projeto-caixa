create database if not exists cocodonilson;
use cocodonilson;

create table if not exists fechamentoCaixa
(
idFechamento INT NOT NULL AUTO_INCREMENT,
copo200 int not null,
copo300 int not null,
copo400 int not null,
copo500 int not null,
garrafa500 int not null,
garrafa1L int not null,
garrafa2L int not null,
fidelidade1L int not null,
fidelidade2L int not null,
cGarrafa1L int not null,
cGarrafa2L int not null,
lascas int not null,
coco int not null,
gelo int not null,
gastos int not null,
descricaoGastos varchar(45) not null,
vendasDinheiro double not null,
vendasOnline double not null,
lucro double not null,
dizimo double not null,
dataFechamento date not null,
primary key(idFechamento)
); 

