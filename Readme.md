criar uma inclusão  de usuarios, onde os dados: Id, E-mail e Senha deverão ser persistidos em N fontes de dados.

Criar uma inclusão de Clientes, os dados Id, nome, email, cpf, data de nascimento e idade( a idade deverá sercalculada de forma automaticae não precisa ser persistida) e o Id do usuario que fez a inclusão.


Regras:
O e-mail terá que ser consistido, e só pode aceitar informação válida:e-mail@dominio.com (por exemplo)
O Id  deverá ser calculado de forma automatica
Senha deverá conter no mínimo 6 digitos
Nome não pode ser em branco
CPF deverá ser consistido (ter no mínimo 11 dígitos)
A gravaçãopoderá ser feita no formato texto ou json dependendo do parametro na configuração. Fazer essa rotina sem uso de IF's



Sugestão de  arquitetura:
Domain
Database
   Model
   Repository

CQS
Commands
    Usuario
    Cliente
