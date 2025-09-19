# Implementando-Associacoes-01-e-11-em-C-
Resolução da Atividade Implementando Associacoes 0.1 e 1.1 em C#

##Cenario escolhido: 
Veiculos -  Ratreador/Placa 
 - 0..1: Veiculo -> Rastreador
 - 1:1: veiculo -> Placa

##Tabela Invariantes:

##Decisões de navegabilidade:

##Justificativas:
###Associação entre Veiculo e Rastreador
 A decisão de permitir a navegação bidirecional (tanto do Veículo para o Rastreador quanto do Rastreador para o Veículo) é justificada pela funcionalidade do sistema. O rastreador precisa ter acesso ao veículo ao qual está associado para poder atualizar a quilometragem dele. Por exemplo, a classe Rastreador possui um método alterarQuilometragem() que interage diretamente com o objeto Veiculo para somar a quilometragem. Além disso, em cenários futuros, o veículo pode precisar acessar dados do rastreador para relatórios ou monitoramento, tornando a navegação bidirecional mais eficiente.

 ###Associação entre Veiculo e Placa
 A navegação bidirecional entre o Veículo e a Placa é essencial para a operação do sistema. A placa não existe sem um veículo, e o veículo precisa da placa para identificação. A principal justificativa para essa navegação é a funcionalidade de aplicarMulta(), presente na classe Placa. Para que a multa seja aplicada e registrada corretamente, a placa precisa acessar o modelo do veículo (_veiculo!.Modelo) ao qual ela pertence, conforme demonstrado no código. Essa interdependência funcional torna a navegação bidirecional a escolha mais lógica e prática.

##Diagrama Curto:
<img width="1297" height="632" alt="image" src="https://github.com/user-attachments/assets/cedf9605-50d9-41a4-9248-3c515c8e471c" />


