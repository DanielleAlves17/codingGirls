namespace Aula_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_____________________________            Exercícios          ________________________________________
            //1.Cadastro de Alunos
            //Considere uma classe Aluno. Esta classe possui como atributos privados o nome, as notas e a frequência.
            //Além do construtor, esta classe deve conter os métodos que cadastram os alunos, adiciona suas notas,
            //consulta um aluno por código e consulta todos os alunos do cadastro.

            Aluno aluno02 = new Aluno("Ivan", "202202", 8.0d, 4.5d,20);
            aluno02.NotaFinal();



            //2.Sistema de Login
            //Desenvolva um programa de contas com login e senha privados. Além disso criptogafe esta senha para que
            //ela fique muito segura.
            //Além do método construtor, implemente os seguintes métodos
            //Criação de conta;
            //Alterar a senha;
            //Entrar no Sistema: Neste método o usuário deve digitar seu usuário e depois sua senha.
            //A classe de contas deve validar se este usuário existe, caso não exista exiba:
            //Este usuário não existe!
            //Caso o usuário exista e a senha esteja errada:
            //Senha incorreta!
            //Caso usuário e senha estejam corretos exiba:
            //Bem vindo ao sistema!
            //(não fiz ainda)




            //3.Conta Bancária
            //Crie uma classe Conta Bancária que possua os seguintes atributos: número da conta, nome do cliente
            //e saldo privados.Além dos métodos de get para os atributos crie um método para alterar o nome,
            //realizar depósitos e saques. Também construa um construtor onde saldo é opcional, com valor default
            //zero, já os demais atributos são obrigatórios.
            //(não fiz ainda)





            //4.Pet Shop
            //Vamos modelar um cadastro de animais de uma pet-shop ? Crie uma classe que modele os animais e contenha
            //como atributos nome, espécie, cor, idade, observação e dados do dono.Os atributos relacionados ao dono
            //do animal deve ser privados para proteção de dados.Forrneça métodos para cadastro e leitura das informações.
            //(não fiz ainda)





            //5.Televisão
            //Faça um programa que simule uma tv.A classe de televisão deve ter atributos de marca, código de série
            //privado, uma lista de canais com nome e número, volume e status.Forneça métodos para ligar e desligar o
            //televisor, aumentar ou diminuir o volume.
            //Certifique - se de que o número do canal existe e informe pro usuário caso não exista;
            //Controle o nível do volume, não permitindo que o usuário exceda o limite de volume;
            //Valide se a televisão está ligada antes de trocar de canal ou altear o volume.
            //Permita que o cliente possa visualiza todos os atributos da televisão.
            //(não fiz ainda)





        }
    }
}
