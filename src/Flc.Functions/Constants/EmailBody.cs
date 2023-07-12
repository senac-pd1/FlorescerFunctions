namespace Flc.Functions.Constants
{
    public static class EmailBody
    {
        public static readonly string header = "<!DOCTYPE html>\n" +
            "<html>\n" +
            "<head>\n" +
            "    <meta charset=\"UTF-8\">\n" +
            "    <style>\n" +
            "        body {\n" +
            "            font-family: Arial, sans-serif;\n" +
            "            background-color: #f4f4f4;\n" +
            "            padding: 20px;\n" +
            "        }\n" +
            "        .container {\n" +
            "            background-color: #ffffff;\n" +
            "            max-width: 600px;\n" +
            "            margin: 0 auto;\n" +
            "            padding: 20px;\n" +
            "            border-radius: 5px;\n" +
            "            box-shadow: 0 2px 6px rgba(0,0,0,0.1);\n" +
            "        }\n" +
            "        h1 {\n" +
            "            color: #333333;\n" +
            "            font-size: 28px;\n" +
            "            margin-bottom: 30px;\n" +
            "        }\n" +
            "        p {\n" +
            "            color: #555555;\n" +
            "            font-size: 16px;\n" +
            "            margin-bottom: 20px;\n" +
            "            line-height: 1.5;\n" +
            "        }\n" +
            "        .tips-list {\n" +
            "            margin-bottom: 30px;\n" +
            "        }\n" +
            "        .tips-list li {\n" +
            "            margin-bottom: 15px;\n" +
            "            list-style-type: disc;\n" +
            "        }\n" +
            "        .signature {\n" +
            "            color: #777777;\n" +
            "            font-style: italic;\n" +
            "        }\n" +
            "        .button {\n" +
            "            display: inline-block;\n" +
            "            background-color: #4CAF50;\n" +
            "            color: #ffffff;\n" +
            "            padding: 10px 20px;\n" +
            "            text-decoration: none;\n" +
            "            border-radius: 5px;\n" +
            "        }\n" +
            "        .footer {\n" +
            "            margin-top: 40px;\n" +
            "            padding-top: 20px;\n" +
            "            border-top: 1px solid #dddddd;\n" +
            "            text-align: center;\n" +
            "        }\n" +
            "    </style>\n" +
            "</head>\n" +
            "<body>\n" +
            "    <div class=\"container\">\n";

        public static readonly string template = "<h1>Lembrete Semanal de Cuidados com a Samambaia &#127807;</h1>\n" +
            "        <p>Olá,</p>\n" +
            "        <p>É hora de cuidar da sua adorável Samambaia! Aqui estão algumas dicas e lembretes para garantir que ela continue saudável e exuberante durante toda a semana:</p>\n" +
            "        <ul class=\"tips-list\">\n" +
            "            <li>\n" +
            "                <strong>Rega:</strong> A Samambaia aprecia umidade constante, mas evite encharcar o solo. Verifique a umidade antes de regar. Se o solo estiver seco ao toque, é hora de regar suavemente. Lembre-se de que é melhor regar com moderação do que em excesso.\n" +
            "            </li>\n" +
            "            <li>\n" +
            "                <strong>Iluminação:</strong> Sua Samambaia prospera em luz indireta brilhante. Certifique-se de colocá-la em um local onde receba luz filtrada durante o dia. Evite expô-la diretamente ao sol, pois isso pode danificar as folhas sensíveis.\n" +
            "            </li>\n" +
            "            <li>\n" +
            "                <strong>Umidade:</strong> A umidade é crucial para a saúde da sua Samambaia. Tente manter um ambiente úmido ao redor da planta. Você pode borrifar água nas folhas regularmente ou colocar uma bandeja com água próxima a ela para criar um microclima mais úmido.\n" +
            "            </li>\n" +
            "            <li>\n" +
            "                <strong>Fertilização:</strong> A cada duas semanas, durante a primavera e o verão, você pode fornecer um pouco de nutrição extra para a sua Samambaia. Use um fertilizante balanceado diluído e aplique-o de acordo com as instruções do fabricante. No outono e inverno, a fertilização pode ser reduzida ou suspensa.\n" +
            "            </li>\n" +
            "            <li>\n" +
            "                <strong>Limpeza:</strong> Remova folhas murchas, secas ou danificadas regularmente. Isso não apenas manterá sua planta esteticamente agradável, mas também ajudará a prevenir doenças e infestações.\n" +
            "            </li>\n" +
            "        </ul>\n";
        
        public static readonly string footer = "<p>Lembre-se de que cada planta é única, então fique atento aos sinais que sua Samambaia lhe dá. Observe se as folhas estão ficando amareladas, murchas ou se há algum sinal de infestação. Isso pode indicar que algo não está certo, e você poderá agir em conformidade.</p>\n" +
            "        <p>Aproveite o tempo para relaxar e apreciar a beleza da natureza que a Samambaia traz ao seu ambiente.</p>\n" +
            "        <div class=\"footer\">\n" +
            "            <p class=\"signature\">Atenciosamente,<br>Equipe Florescer</p>\n" +
            "            <img alt=\"Logo do projeto Florescer.\" src=\"https://senac-pd1.github.io/FlorescerMedia/imagens/logoFlorescer.png\">" +
            "        </div>\n" +
            "    </div>\n" +
            "</body>\n" +
            "</html>\n";

    }
}
