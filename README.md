# TesteOnlineApp

Para rodar a aplicação, baixe a branch localmente, abra com o visual studio 2019 e restaure os pacotes NuGet da solução.

O que foi feito:

- Alterado o tipo do método Get para publico, na CepController (estava privado)

- Adicionado a injeção de dependencia para a ViaCepServiceClient no startup

- Adicionado mapeamento GetCepQuery para CepRequest, para atender o mapeamento na GetCepQueryHandler linha 24

- Linha 44 alterada na GetCepQueryHandler, para realizar o mapeamento  de CepResponse para GetCepQueryResponse (antes estava mapeando apenas a mensagem da CepResponse)

- Serializando o retorno da api viacep para o objeto CepResponse, usando Newtonsoft

- Adicionado services.AddMvc().AddXmlSerializerFormatters(); para ter a possibilidade de retornar em xml tbm
