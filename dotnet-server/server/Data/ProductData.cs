using server.Dto;

namespace server.Data
{
    public class ProductData
    {
        public static List<ProductDto> datas = new()
        {
            new ProductDto {
                id = 1, name = "古早味麥芽餅", category = "零食", price = 35, stock = 28,
                imageUrl = "images/products/1.png",
                desc = "用傳統配方製作，香脆餅皮包覆濃郁麥芽糖，勾起童年的甜蜜記憶。" },
            new ProductDto {
                id = 2, name = "手工鳳梨酥", category = "糕點", price = 25, stock = 5,
                imageUrl = "images/products/2.png",
                desc = "純手工製作，外皮酥鬆，內餡甜而不膩，是柑仔店的招牌伴手禮。" },
            new ProductDto {
                id = 3, name = "黑糖珍珠奶茶", category = "飲料", price = 65, stock = 0,
                imageUrl = "images/products/3.png",
                desc = "精選台灣黑糖熬製，搭配手工粉圓，甜蜜濃郁的古早滋味。" },
            new ProductDto {
                id = 4, name = "原味米餅", category = "零食", price = 20, stock = 35,
                imageUrl = "images/products/4.png",
                desc = "精選在地米烘焙而成，無添加人工色素，香脆可口。" },
            new ProductDto {
                id = 5, name = "檸檬塔", category = "糕點", price = 45, stock = 12,
                imageUrl = "images/products/5.png",
                desc = "酸甜清爽的法式檸檬塔，每日限量手工製作。" },
            new ProductDto {
                id = 6, name = "烏龍綠茶", category = "飲料", price = 28, stock = 50,
                imageUrl = "images/products/6.png",
                desc = "嚴選高山烏龍茶葉，清香甘醇，回甘持久。" },
            new ProductDto {
                id = 7, name = "花生牛奶糖", category = "零食", price = 30, stock = 20,
                imageUrl = "images/products/7.png",
                desc = "傳統工法製作，香濃花生搭配軟Q糖體，甜而不黏牙。" },
            new ProductDto {
                id = 8, name = "鳳梨豆瓣醬", category = "醬料", price = 60, stock = 8,
                imageUrl = "images/products/8.png",
                desc = "在地鳳梨與黑豆發酵釀製，酸甜鹹香，拌飯拌麵皆宜。" },
        };
    }
}
