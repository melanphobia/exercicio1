/*create table tb_contatos(
	id int primary key auto_increment,
    nome varchar(45),
    email varchar(45),
	fone varchar(45)
);*/
drop table tb_contatos;

/*create table tb_locais(
	id int primary key auto_increment,
    nome varchar(45) not null,
    rua varchar(45),
    numero int
)*/

/*create table tb_compromissos(
	id int primary key auto_increment,
    descricao varchar(100) not null,
    data date not null,
    hora time not null
)*/

alter table tb_compromissos
add column tb_contatos_id int;

alter table tb_compromissos
add constraint fk_contatostb_compromissos
foreign key(tb_contatos_id)
references tb_contatos(id);

alter table tb_locais
add constraint fk_contatostb_locais
foreign key(tb_contatos_id)
references tb_contatos(id);

/*create table tb_compromissos(
   id int primary key auto_increment,
   descricao varchar(100) not null,
   data date not null,
   hora time not null,
   tb_contatos_id int not null,
   tb_locais_id int not null,
   foreign key(tb_contatos_id) references tb_contatos(id),
   foreign key(tb_locais_id) references tb_locais(id)
)*/

drop table tb_compromissos;
drop table tb_locais;

/*create table tb_compromissos(
   id int primary key auto_increment,
   descricao varchar(100) not null,
   data date not null,
   hora time not null,
   tb_contatos_id int not null,
   tb_locais_id int not null,
   foreign key(tb_contatos_id) references tb_contatos(id),
   foreign key(tb_locais_id) references tb_locais(id)
)*/