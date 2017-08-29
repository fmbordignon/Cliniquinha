Ela moide :3

# Links Útes

http://www.eduardopires.net.br/2014/03/asp-net-identity-customizando-cadastro-usuarios/
https://www.codeproject.com/Articles/790720/ASP-NET-Identity-Customizing-Users-and-Roles

https://stackoverflow.com/questions/25884399/aspnetusers-id-as-foreign-key-in-separate-table-one-to-one-relationship

https://stackoverflow.com/questions/42663471/add-primary-key-of-linked-table-to-aspnetusers-table-id-field

https://code.msdn.microsoft.com/ASPNET-MVC-5-Security-And-44cbdb97

https://stackoverflow.com/questions/42163390/can-i-create-multiple-identity-tables-in-asp-net-mvc&usg=ALkJrhidAFUUFD-qn-UMggZ7q6ZKdmw6_A


# O que falta fazer (28/08)

- Validar Especialização no Front (register.cs)
- Adicionar mascarar na consulta (Data, hora)
- Adicionar Required na consulta
- Opção de Criar paciente remover os campos de endereço e data de nascimento
- Required Paciente
- Criar filtro no Paciente
- Trocar a label do medico na Consulta
- Validar consulta com a data

- O paciente pode desmarcar uma consulta previamente agendada. Caso a consulta seja desmarcada antes de sua data prevista, ela é excluída. Se o paciente não comparecer à consulta, a consulta fica registrada no sistema como sendo uma consulta sem comparecimento. 

- Quando um paciente comparece na clínica para ser consultado, caso seja a primeira vez, deve-se completar o cadastro do paciente, informando data de nascimento e endereço. Durante uma consulta, o médico pode registrar observações livremente (p.ex., exames solicitados, resultados, quadro clínico etc.).

- O sistema deverá ter um cadastro de usuários um controle de acesso básico (Login/senha) e para cada tipo de usuário deverá aparecer somente as ações permitidas a ele.
