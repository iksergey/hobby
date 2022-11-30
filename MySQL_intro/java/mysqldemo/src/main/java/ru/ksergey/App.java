package ru.ksergey;

import java.sql.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public final class App {

    public static void main(String[] args) throws SQLException {

        String db = "computer_shop";

        String host = "127.0.0.1";
        String port = "3307";
        String pattern = "jdbc:mysql://%s:%s/%s";
        String url = String.format(pattern,
                host, port, db);

        String user = "username";
        String password = "password";

        Connection connection = DriverManager.getConnection(url, user, password);
        Statement statement = connection.createStatement();

        // String insert = "INSERT into Product values('D','8888','PC')";
        // boolean result = statement.execute(insert);
        // System.out.println(insert);

        // String sql = "SELECT * FROM Product;";
        // Чуть более сложный запрос
        StringBuilder sql = new StringBuilder()
                .append("SELECT \n")
                .append("    maker  \n")
                .append("  , Product.model AS `model`  \n")
                .append("  , type  \n")
                .append("  , speed  \n")
                .append("  , ram  \n")
                .append("  , hd  \n")
                .append("  , price  \n")
                .append("FROM Product LEFT JOIN PC  \n")
                .append("ON PC.model = Product.model  \n")
                .append("WHERE code IS NOT NULL  \n")
                .append("ORDER BY maker, price; ")
                .append("");

        System.out.printf("URL %s\n SQL %s\n\n", url, sql);

        ResultSet rs = statement.executeQuery(sql.toString());

        while (rs.next()) {
            // Обращение к полям по имени
            // String maker = rs.getString("maker");
            // String model = rs.getString("model");
            // String type = rs.getString("type");
            // System.out.printf("%10s %10s %10s\n", maker, model, type);

            // Обращение к полям по номерам
            for (int i = 1; i < 7; i++) {
                System.out.printf("%10s", rs.getString(i));
            }
            System.out.println();
        }

        rs.close();
        statement.close();
        connection.close();

    }
}
