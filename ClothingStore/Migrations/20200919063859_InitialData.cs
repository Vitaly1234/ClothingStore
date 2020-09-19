using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingStore.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Arrived", "Availability", "Description", "Name", "Size", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 9, 10, 38, 57, 579, DateTimeKind.Local).AddTicks(8207), "OutStock", "Sit sed amet voluptatem dignissimos perspiciatis officia nesciunt id. Quae qui ea earum perspiciatis maxime minus dolorum. Autem similique quam vero tempore culpa ut quia repudiandae. Maxime omnis et ut in illo unde nostrum earum.", "Product 1", "M", "Footwear" },
                    { 659, new DateTime(2020, 8, 17, 10, 38, 57, 993, DateTimeKind.Local).AddTicks(7798), "OutStock", "Voluptatem soluta sed ipsam voluptatem iure. Expedita et sunt rerum est doloribus. Unde qui libero eligendi.", "Product 659", "M", "Accessory" },
                    { 660, new DateTime(2020, 8, 25, 10, 38, 57, 994, DateTimeKind.Local).AddTicks(114), "OutStock", "Modi ipsa ex eveniet fugiat. Est totam eum pariatur. Architecto expedita nemo qui blanditiis.", "Product 660", "S", "Outerwear" },
                    { 661, new DateTime(2020, 6, 19, 10, 38, 57, 994, DateTimeKind.Local).AddTicks(4618), "InStock", "Voluptatem ipsum optio alias et id vel fugit in. Asperiores autem et ut laborum eos. Cum laudantium impedit ipsam quibusdam molestias sit est cum. Nesciunt aut ut eum ullam occaecati.", "Product 661", "XS", "Accessory" },
                    { 662, new DateTime(2020, 9, 14, 10, 38, 57, 994, DateTimeKind.Local).AddTicks(9400), "InStock", "Ut eligendi et blanditiis. Consectetur ut incidunt et repudiandae molestiae mollitia. Quaerat doloremque dicta officiis non in odit ipsam quia. Perferendis ullam sit consequatur vero blanditiis et. Quaerat molestiae ullam sint.", "Product 662", "S", "Accessory" },
                    { 663, new DateTime(2020, 8, 19, 10, 38, 57, 995, DateTimeKind.Local).AddTicks(2668), "OutStock", "Recusandae nihil molestias accusantium molestiae quos sit asperiores. Delectus ea qui ea expedita ut ut nam. Quisquam consequatur est et recusandae.", "Product 663", "S", "Underwear" },
                    { 664, new DateTime(2020, 8, 2, 10, 38, 57, 995, DateTimeKind.Local).AddTicks(6277), "OutStock", "Quisquam aut dignissimos praesentium voluptate velit distinctio. Eveniet vero voluptas sapiente minima. Quas temporibus modi sed velit rerum suscipit. Possimus nihil deleniti veniam.", "Product 664", "L", "Footwear" },
                    { 665, new DateTime(2020, 7, 15, 10, 38, 57, 995, DateTimeKind.Local).AddTicks(9273), "OutStock", "Nulla soluta accusamus amet. Impedit placeat maiores deleniti voluptates porro quae eum maiores. Inventore maxime hic in repellendus doloribus.", "Product 665", "S", "Outerwear" },
                    { 666, new DateTime(2020, 8, 9, 10, 38, 57, 996, DateTimeKind.Local).AddTicks(3332), "OutStock", "Ipsam omnis labore sed id asperiores sunt maxime maxime. Possimus ut consequuntur velit corrupti itaque molestiae sapiente dicta. Qui porro nobis eum cum dolore pariatur impedit qui.", "Product 666", "S", "Underwear" },
                    { 667, new DateTime(2020, 8, 31, 10, 38, 57, 996, DateTimeKind.Local).AddTicks(7624), "InStock", "Aut consequatur rerum iusto repellendus eos quidem qui. Vel maxime repellendus id sunt autem debitis. Doloribus non alias eius eum enim non. Molestiae dolorem est recusandae excepturi soluta.", "Product 667", "S", "Accessory" },
                    { 668, new DateTime(2020, 8, 15, 10, 38, 57, 997, DateTimeKind.Local).AddTicks(798), "OutStock", "Recusandae eius ut enim et laborum tempora laudantium est. Nobis vel neque consequatur accusantium. Minus dignissimos deserunt sint cupiditate dolor.", "Product 668", "L", "Footwear" },
                    { 669, new DateTime(2020, 8, 13, 10, 38, 57, 997, DateTimeKind.Local).AddTicks(3435), "OutStock", "Iusto modi a deleniti voluptatem. Rerum dolorum nisi eum. Quia in voluptatem fuga corrupti laboriosam inventore.", "Product 669", "S", "Accessory" },
                    { 670, new DateTime(2020, 6, 13, 10, 38, 57, 997, DateTimeKind.Local).AddTicks(6108), "InStock", "Assumenda quia suscipit sint facere. Sit recusandae ut perferendis cum ipsa quam. Ducimus quas modi dolore.", "Product 670", "L", "Footwear" },
                    { 671, new DateTime(2020, 9, 5, 10, 38, 57, 998, DateTimeKind.Local).AddTicks(928), "InStock", "Fuga excepturi voluptas ex mollitia animi et. Id fugiat quia velit sint. Omnis libero qui dolorem. Sunt dolor beatae amet at quae at vel architecto. Eveniet non quia non dignissimos reprehenderit magni.", "Product 671", "L", "Underwear" },
                    { 672, new DateTime(2020, 7, 26, 10, 38, 57, 998, DateTimeKind.Local).AddTicks(5903), "OutStock", "Rerum aliquam commodi unde veniam numquam consequatur saepe vel. Ad distinctio quas nemo tempora. Non odit amet vel. Aut ut numquam cumque quisquam deleniti autem. Beatae fugit aut harum quaerat dolorem fugiat enim.", "Product 672", "XS", "Underwear" },
                    { 673, new DateTime(2020, 8, 8, 10, 38, 57, 998, DateTimeKind.Local).AddTicks(9340), "InStock", "Adipisci voluptas voluptate culpa aut. Voluptas saepe ut a sed molestias qui. Dolore recusandae dolore qui. Qui incidunt consectetur omnis ipsum ut.", "Product 673", "S", "Accessory" },
                    { 674, new DateTime(2020, 9, 7, 10, 38, 57, 999, DateTimeKind.Local).AddTicks(2551), "InStock", "Unde eos qui in sunt accusantium. Non qui voluptatem magni. Possimus qui sequi qui necessitatibus. Et exercitationem assumenda iure commodi.", "Product 674", "M", "Outerwear" },
                    { 675, new DateTime(2020, 9, 9, 10, 38, 57, 999, DateTimeKind.Local).AddTicks(5736), "OutStock", "Rerum expedita natus dolorem non. Autem eius omnis sed. Nesciunt laudantium explicabo aut sed. Porro possimus laudantium distinctio voluptates eius.", "Product 675", "L", "Underwear" },
                    { 676, new DateTime(2020, 9, 4, 10, 38, 57, 999, DateTimeKind.Local).AddTicks(9414), "InStock", "Qui qui necessitatibus et. Unde rerum quae amet cumque. Quod rerum beatae illum recusandae nulla adipisci. Sapiente sit itaque quam maxime officia delectus dolore.", "Product 676", "XS", "Accessory" },
                    { 677, new DateTime(2020, 8, 6, 10, 38, 58, 0, DateTimeKind.Local).AddTicks(2163), "InStock", "Commodi et optio ab et ipsum enim. Laudantium quasi facere sunt. Illum necessitatibus id ut quia incidunt.", "Product 677", "XS", "Accessory" },
                    { 678, new DateTime(2020, 7, 4, 10, 38, 58, 0, DateTimeKind.Local).AddTicks(6579), "InStock", "Perspiciatis et deserunt doloribus assumenda consequatur qui ea. Et aut hic non dolorem. Soluta fugiat eligendi dicta repudiandae tenetur quia. Non id et et ratione. Voluptatem qui voluptas qui.", "Product 678", "L", "Underwear" },
                    { 679, new DateTime(2020, 8, 20, 10, 38, 58, 1, DateTimeKind.Local).AddTicks(2100), "OutStock", "Minima omnis id quos ad autem aut quis. Molestiae cumque impedit id debitis quidem nesciunt. Voluptas repellendus ad doloribus et qui eos fugit. Quia repudiandae doloremque ut nulla consectetur ut enim. Sed natus consequatur rerum a earum ut.", "Product 679", "L", "Underwear" },
                    { 680, new DateTime(2020, 6, 12, 10, 38, 58, 1, DateTimeKind.Local).AddTicks(5725), "OutStock", "Mollitia repellendus voluptatem aut. Voluptate laborum aut qui accusantium est. Labore aspernatur reprehenderit sunt et. Porro natus aliquid qui qui vero aut saepe.", "Product 680", "M", "Underwear" },
                    { 681, new DateTime(2020, 8, 2, 10, 38, 58, 1, DateTimeKind.Local).AddTicks(9706), "InStock", "Sint est voluptatem officia necessitatibus quibusdam ad omnis. Et totam necessitatibus magnam maxime. Odit eum in aut. Mollitia quo culpa nam reiciendis a repellendus et rerum.", "Product 681", "L", "Footwear" },
                    { 682, new DateTime(2020, 9, 18, 10, 38, 58, 2, DateTimeKind.Local).AddTicks(4472), "InStock", "Modi molestiae aut praesentium. Beatae numquam sed iure non voluptatem molestiae repellat. Consequatur qui quod nulla non corporis. Ullam et pariatur assumenda doloribus asperiores totam. Id quos quidem quae debitis unde ullam.", "Product 682", "S", "Accessory" },
                    { 683, new DateTime(2020, 8, 23, 10, 38, 58, 2, DateTimeKind.Local).AddTicks(7496), "InStock", "Est autem cum deserunt ipsa praesentium. Cupiditate itaque nemo mollitia. Laudantium repellendus voluptas voluptatem sit consequatur ducimus corporis numquam.", "Product 683", "XS", "Underwear" },
                    { 684, new DateTime(2020, 7, 13, 10, 38, 58, 3, DateTimeKind.Local).AddTicks(90), "InStock", "In voluptates nemo maiores. Quidem voluptatem ut nulla totam. Perferendis sed laudantium aut itaque delectus et.", "Product 684", "L", "Footwear" },
                    { 685, new DateTime(2020, 7, 23, 10, 38, 58, 3, DateTimeKind.Local).AddTicks(4862), "OutStock", "Ut dolore sint quasi voluptas cumque. Impedit sed commodi id soluta et unde voluptates atque. Quia vero autem officia quibusdam sapiente ullam eum eius. Voluptatem voluptatem quisquam consequatur qui pariatur sit asperiores.", "Product 685", "XS", "Footwear" },
                    { 658, new DateTime(2020, 6, 24, 10, 38, 57, 993, DateTimeKind.Local).AddTicks(5154), "InStock", "Officiis suscipit hic aut alias voluptatibus vel consectetur consequuntur. Et ad tempora possimus enim. Perspiciatis exercitationem ad accusantium quasi.", "Product 658", "XS", "Footwear" },
                    { 686, new DateTime(2020, 6, 13, 10, 38, 58, 3, DateTimeKind.Local).AddTicks(9474), "OutStock", "Vitae blanditiis quaerat enim dolorum et deserunt. Aliquid voluptatibus libero quibusdam odio. Eveniet eaque molestias reiciendis. Voluptas reprehenderit voluptas aut maiores. Aut dolorem a voluptas mollitia ut ipsum fugit ducimus.", "Product 686", "S", "Footwear" },
                    { 657, new DateTime(2020, 8, 1, 10, 38, 57, 993, DateTimeKind.Local).AddTicks(2129), "OutStock", "Error amet earum omnis consequatur eaque. Animi voluptas voluptate expedita ea eius at dolorem numquam. Et non eveniet qui modi laboriosam.", "Product 657", "S", "Footwear" },
                    { 655, new DateTime(2020, 7, 30, 10, 38, 57, 992, DateTimeKind.Local).AddTicks(3521), "InStock", "Vero esse aut est. Id voluptas repellendus explicabo tenetur voluptas non ullam explicabo. Rem distinctio praesentium consequuntur qui nihil voluptatem.", "Product 655", "XS", "Footwear" },
                    { 628, new DateTime(2020, 7, 8, 10, 38, 57, 981, DateTimeKind.Local).AddTicks(9429), "InStock", "Iure dolorum hic esse veniam quia non amet. Nostrum voluptatem quia omnis dicta architecto est et hic. Magni ut et fugiat dolor nemo cum.", "Product 628", "XS", "Underwear" },
                    { 629, new DateTime(2020, 7, 14, 10, 38, 57, 982, DateTimeKind.Local).AddTicks(3864), "InStock", "Sequi voluptatibus facilis facere odio expedita dignissimos. Omnis nulla ex eaque quia animi est sed excepturi. Eaque amet consequatur ad totam aliquid molestiae deleniti sit. Temporibus et voluptas nisi.", "Product 629", "XS", "Accessory" },
                    { 630, new DateTime(2020, 8, 2, 10, 38, 57, 982, DateTimeKind.Local).AddTicks(7915), "OutStock", "Aut consequatur nihil molestiae. Ratione nam et assumenda dolor. Excepturi totam ducimus voluptates laboriosam sit. Et labore sed assumenda eum. Quaerat facilis quia dolor hic et.", "Product 630", "S", "Underwear" },
                    { 631, new DateTime(2020, 7, 5, 10, 38, 57, 983, DateTimeKind.Local).AddTicks(1428), "OutStock", "Repudiandae deserunt et sequi a autem. Velit reiciendis dicta in unde accusantium quisquam nesciunt cumque. Officiis exercitationem ullam aspernatur omnis quis recusandae quibusdam.", "Product 631", "XS", "Underwear" },
                    { 632, new DateTime(2020, 9, 4, 10, 38, 57, 983, DateTimeKind.Local).AddTicks(4138), "OutStock", "Odit mollitia aut rerum molestias et pariatur. Iure dicta et adipisci. Quis et quia ullam quisquam doloremque.", "Product 632", "M", "Footwear" },
                    { 633, new DateTime(2020, 9, 1, 10, 38, 57, 983, DateTimeKind.Local).AddTicks(6665), "InStock", "Adipisci aut ab pariatur. At eos ut veniam distinctio maxime. Vel nihil odio beatae at.", "Product 633", "M", "Underwear" },
                    { 634, new DateTime(2020, 6, 25, 10, 38, 57, 984, DateTimeKind.Local).AddTicks(2251), "OutStock", "Et dolores voluptatem quisquam. Cupiditate laudantium suscipit soluta aliquam et dolorum cupiditate. Dolores consequatur itaque quia beatae rerum quod voluptatem. Quos modi voluptate voluptate sint eveniet harum asperiores voluptas. Doloremque quia sed id enim sequi repudiandae voluptate odit.", "Product 634", "L", "Underwear" },
                    { 635, new DateTime(2020, 7, 7, 10, 38, 57, 984, DateTimeKind.Local).AddTicks(5160), "InStock", "Non voluptatem tempora omnis fugit. Ex tempora similique in architecto nam et incidunt adipisci. Non natus deleniti amet.", "Product 635", "M", "Underwear" },
                    { 636, new DateTime(2020, 8, 22, 10, 38, 57, 985, DateTimeKind.Local).AddTicks(400), "InStock", "Quia enim est sunt aut quod consequatur voluptatibus sed. Officia eum repellat et et quas totam. Dolores ab ipsam sunt fugit veritatis perferendis. Esse enim quo excepturi qui consequatur omnis veritatis iure.", "Product 636", "S", "Outerwear" },
                    { 637, new DateTime(2020, 6, 24, 10, 38, 57, 985, DateTimeKind.Local).AddTicks(4247), "InStock", "Dolore omnis fugiat saepe ut ut voluptatem consectetur consequatur. Perspiciatis consectetur distinctio nobis facere qui nisi. Accusantium distinctio est quisquam dolorem animi enim at doloremque.", "Product 637", "S", "Underwear" },
                    { 638, new DateTime(2020, 8, 1, 10, 38, 57, 985, DateTimeKind.Local).AddTicks(8158), "InStock", "Qui consequatur praesentium dolor. Reiciendis rem dolorem exercitationem ducimus. Voluptate consequatur vel qui et dolor est. Porro iure molestiae dolorem expedita soluta et est similique.", "Product 638", "S", "Underwear" },
                    { 639, new DateTime(2020, 7, 1, 10, 38, 57, 986, DateTimeKind.Local).AddTicks(1278), "OutStock", "Laborum eum recusandae aspernatur. Voluptas et a in animi autem qui voluptatem. Sint facilis nam sit enim quis qui quo.", "Product 639", "S", "Footwear" },
                    { 640, new DateTime(2020, 6, 13, 10, 38, 57, 986, DateTimeKind.Local).AddTicks(6040), "OutStock", "Repellendus minima eius recusandae et quidem veritatis nobis. Odit quisquam est aut consequuntur velit ipsa voluptates eaque. Reiciendis minus eos possimus est quod. Unde sit laudantium rem ex voluptatibus repellendus dolore.", "Product 640", "M", "Accessory" },
                    { 641, new DateTime(2020, 8, 12, 10, 38, 57, 987, DateTimeKind.Local).AddTicks(668), "InStock", "Aliquid ratione omnis quos autem eos molestiae veniam. Et enim voluptatem officia. Voluptatem itaque incidunt illum. Harum commodi non iste ullam consequatur enim assumenda earum. Corrupti rerum et a ipsa magnam.", "Product 641", "S", "Underwear" },
                    { 642, new DateTime(2020, 9, 9, 10, 38, 57, 987, DateTimeKind.Local).AddTicks(4450), "OutStock", "Eos reiciendis et voluptas. Iure eum at dolore aliquam aspernatur iusto quia. Ut voluptatem ipsa dolores neque debitis in omnis. Et consequuntur ullam harum non.", "Product 642", "XS", "Underwear" },
                    { 643, new DateTime(2020, 6, 26, 10, 38, 57, 987, DateTimeKind.Local).AddTicks(7275), "OutStock", "Ducimus non voluptatum quos non beatae. Ea odio adipisci asperiores id id rerum. Inventore velit est aut.", "Product 643", "M", "Outerwear" },
                    { 644, new DateTime(2020, 8, 13, 10, 38, 57, 987, DateTimeKind.Local).AddTicks(9717), "OutStock", "Deleniti fugit dolores est. Perferendis corrupti autem corrupti. Commodi voluptas possimus quam dolores in modi.", "Product 644", "M", "Footwear" },
                    { 645, new DateTime(2020, 7, 25, 10, 38, 57, 988, DateTimeKind.Local).AddTicks(3835), "InStock", "Sunt quia ea sit doloribus. Ut temporibus sed et sint in enim eum. Numquam quam quia at nemo tempore a aut. Molestias ut eveniet eaque exercitationem est.", "Product 645", "M", "Underwear" },
                    { 646, new DateTime(2020, 9, 13, 10, 38, 57, 988, DateTimeKind.Local).AddTicks(7984), "OutStock", "Exercitationem et cupiditate molestias incidunt aut nesciunt. Quasi mollitia nemo sit sint blanditiis sit. Nihil est consequatur molestias natus recusandae. Et nesciunt libero aut autem laboriosam voluptatem.", "Product 646", "XS", "Footwear" },
                    { 647, new DateTime(2020, 8, 5, 10, 38, 57, 989, DateTimeKind.Local).AddTicks(2705), "InStock", "Dolore omnis voluptas pariatur dolor. Temporibus iusto ipsa dicta eveniet consequatur facilis aut. Neque perferendis cum incidunt. Quo ea vel error sapiente consequuntur rerum cumque libero. Nulla deleniti assumenda aperiam illo.", "Product 647", "S", "Outerwear" },
                    { 648, new DateTime(2020, 8, 27, 10, 38, 57, 989, DateTimeKind.Local).AddTicks(5878), "InStock", "Maxime rerum non velit exercitationem. Quam delectus quam beatae voluptatem dolores cum eum et. Vero iste sint voluptates voluptas id.", "Product 648", "L", "Footwear" },
                    { 649, new DateTime(2020, 8, 3, 10, 38, 57, 989, DateTimeKind.Local).AddTicks(9334), "OutStock", "Enim iusto doloremque et id. Enim in aut deleniti eos et. Sapiente laboriosam ipsa et eaque enim eos. Animi expedita vel sint.", "Product 649", "L", "Underwear" },
                    { 650, new DateTime(2020, 6, 13, 10, 38, 57, 990, DateTimeKind.Local).AddTicks(2207), "InStock", "Incidunt culpa qui inventore eum ratione incidunt inventore. Nisi dolorum alias corporis. Et dolores nam est corrupti illum.", "Product 650", "M", "Underwear" },
                    { 651, new DateTime(2020, 6, 21, 10, 38, 57, 990, DateTimeKind.Local).AddTicks(6477), "OutStock", "Impedit eum ut ratione laborum omnis id aperiam repudiandae. Repudiandae earum modi at. Temporibus optio quisquam et. Eum sint velit quisquam. Animi distinctio iste et ratione assumenda illo.", "Product 651", "L", "Outerwear" },
                    { 652, new DateTime(2020, 7, 4, 10, 38, 57, 991, DateTimeKind.Local).AddTicks(1318), "OutStock", "Est aut eligendi sit dolore harum. Ut nesciunt asperiores eum quo voluptate. Inventore voluptatem dolor natus tempore nemo consequatur qui. Totam impedit eveniet fuga. Voluptatem reiciendis eius itaque quia et facilis ut.", "Product 652", "XS", "Underwear" },
                    { 653, new DateTime(2020, 9, 6, 10, 38, 57, 991, DateTimeKind.Local).AddTicks(5253), "InStock", "Temporibus est ad modi. Quam ut accusantium enim quis dolore amet ut quis. Explicabo autem veniam velit. Eum et est aut rerum cum incidunt sit in.", "Product 653", "S", "Accessory" },
                    { 654, new DateTime(2020, 6, 16, 10, 38, 57, 992, DateTimeKind.Local).AddTicks(362), "InStock", "Eligendi sit omnis nihil pariatur voluptatem ea et. Aperiam sit velit iste nisi perspiciatis. Sunt optio atque sed vel. Occaecati ab similique repudiandae modi ex eligendi quia. Tempore occaecati ad nostrum harum earum.", "Product 654", "L", "Accessory" },
                    { 656, new DateTime(2020, 6, 24, 10, 38, 57, 992, DateTimeKind.Local).AddTicks(8808), "InStock", "Voluptatem reprehenderit eius nesciunt quo dolore iusto fuga qui. Illo repellat non consequatur aut ut qui. Facilis recusandae nulla beatae quaerat expedita suscipit. Inventore reiciendis corporis ad. Deleniti vel excepturi autem sapiente consequatur possimus voluptas.", "Product 656", "S", "Footwear" },
                    { 687, new DateTime(2020, 9, 16, 10, 38, 58, 4, DateTimeKind.Local).AddTicks(2722), "InStock", "Dolorem dolor vero aut quia. Iste sequi et sed voluptate magnam et recusandae. Ut recusandae libero et impedit eum magnam ratione.", "Product 687", "M", "Underwear" },
                    { 688, new DateTime(2020, 8, 28, 10, 38, 58, 4, DateTimeKind.Local).AddTicks(7058), "OutStock", "Reiciendis quas nihil blanditiis asperiores dolore porro. Expedita animi sint sit autem veniam dolorem explicabo. Facilis beatae sit est. Perferendis libero ut fugit officia officia quod ut temporibus.", "Product 688", "M", "Footwear" },
                    { 689, new DateTime(2020, 8, 14, 10, 38, 58, 5, DateTimeKind.Local).AddTicks(1856), "OutStock", "Dicta enim odio soluta ut molestias ratione et id. Ex sequi voluptate fugiat voluptatibus ut eius. Fugit architecto consequatur consequuntur quaerat tenetur blanditiis. Veritatis ut enim vel. Sit soluta qui vel dolor.", "Product 689", "M", "Accessory" },
                    { 722, new DateTime(2020, 6, 15, 10, 38, 58, 21, DateTimeKind.Local).AddTicks(5411), "InStock", "Et qui non tempore sapiente necessitatibus impedit. Voluptatibus laboriosam quam quod vel commodi hic quia earum. Omnis quaerat assumenda repellat mollitia rerum sed cum ipsa. Rerum in voluptates tenetur quaerat voluptas.", "Product 722", "L", "Outerwear" },
                    { 723, new DateTime(2020, 6, 12, 10, 38, 58, 21, DateTimeKind.Local).AddTicks(8582), "InStock", "Laudantium fugiat et voluptas voluptatum et corrupti iure. Repudiandae incidunt quasi repellendus nihil. Doloremque adipisci veniam recusandae eveniet. Architecto temporibus consequatur architecto facere saepe sunt.", "Product 723", "XS", "Outerwear" },
                    { 724, new DateTime(2020, 7, 31, 10, 38, 58, 22, DateTimeKind.Local).AddTicks(1157), "OutStock", "Soluta et esse ad nam. Ut autem ea magnam expedita consequatur molestiae ut et. Dolorem dolores rerum minus omnis a.", "Product 724", "S", "Accessory" },
                    { 725, new DateTime(2020, 8, 29, 10, 38, 58, 22, DateTimeKind.Local).AddTicks(5647), "OutStock", "Accusantium aut repudiandae nemo quis maxime. Aperiam excepturi et sequi natus. Voluptatem quidem dolores dolore ipsum autem et ipsum voluptatibus. Eum et id dolore quasi laboriosam facere rerum. Qui aliquam quia quae quae laboriosam veritatis.", "Product 725", "L", "Outerwear" },
                    { 726, new DateTime(2020, 9, 5, 10, 38, 58, 22, DateTimeKind.Local).AddTicks(8001), "OutStock", "Beatae nobis nobis nihil provident autem. Id sequi dicta et sunt. Est ex aut officiis non quo dolor.", "Product 726", "M", "Accessory" },
                    { 727, new DateTime(2020, 8, 12, 10, 38, 58, 23, DateTimeKind.Local).AddTicks(38), "OutStock", "Occaecati ut recusandae perspiciatis. Provident ut fugit atque veniam quis. Quia minus officiis quidem cum.", "Product 727", "M", "Outerwear" },
                    { 728, new DateTime(2020, 6, 25, 10, 38, 58, 23, DateTimeKind.Local).AddTicks(2549), "OutStock", "Consequatur eos voluptas voluptas. Quia nesciunt quia dolorum. Dolorem quae aliquam corporis rem qui sit. Quo dicta molestiae recusandae.", "Product 728", "L", "Underwear" },
                    { 729, new DateTime(2020, 9, 12, 10, 38, 58, 23, DateTimeKind.Local).AddTicks(5164), "OutStock", "Consequatur neque veritatis consectetur in dolores et vel. Rerum commodi veritatis enim quis reprehenderit. Est accusantium architecto minus autem ullam.", "Product 729", "XS", "Accessory" },
                    { 730, new DateTime(2020, 7, 5, 10, 38, 58, 23, DateTimeKind.Local).AddTicks(8357), "OutStock", "Optio officiis officiis qui iure et animi et accusamus. Quidem expedita maxime nisi suscipit. Et quis tempora quo id illo tempore. Nihil sit tempore minus.", "Product 730", "M", "Accessory" },
                    { 731, new DateTime(2020, 8, 14, 10, 38, 58, 24, DateTimeKind.Local).AddTicks(915), "OutStock", "Consequatur consequatur nesciunt ut. Dignissimos amet repudiandae nulla fugit deleniti possimus. Qui tempore officiis sed ut et quis fuga ea.", "Product 731", "M", "Accessory" },
                    { 732, new DateTime(2020, 9, 12, 10, 38, 58, 24, DateTimeKind.Local).AddTicks(4496), "OutStock", "Quidem iste sed similique placeat sed eum. Cum in magnam labore eveniet et et suscipit. Accusamus tenetur dolorem omnis labore rerum nihil. Qui rerum et et.", "Product 732", "L", "Accessory" },
                    { 733, new DateTime(2020, 9, 11, 10, 38, 58, 26, DateTimeKind.Local).AddTicks(4871), "OutStock", "Quibusdam natus aut voluptatibus explicabo eaque dolorum ab eaque. Facilis exercitationem eos facere corporis quia. Eum esse nisi quis. Aliquam qui est vitae porro deleniti totam aut iste. Officia id veritatis iure sint.", "Product 733", "XS", "Footwear" },
                    { 734, new DateTime(2020, 9, 5, 10, 38, 58, 26, DateTimeKind.Local).AddTicks(8233), "OutStock", "Quis et aut aut in placeat saepe ut dolorem. Consequatur non incidunt voluptatem ipsa provident. Aut odio et laboriosam qui. Aliquam atque id quas exercitationem.", "Product 734", "L", "Footwear" },
                    { 735, new DateTime(2020, 9, 6, 10, 38, 58, 27, DateTimeKind.Local).AddTicks(2130), "InStock", "Quos autem inventore et. Aliquid alias ab atque quisquam repellat veritatis. Cupiditate et sunt et autem ducimus dolorum voluptas. Dolores corporis repellat non. Quod eos aut voluptate dolorem est sed esse.", "Product 735", "M", "Underwear" },
                    { 736, new DateTime(2020, 8, 12, 10, 38, 58, 27, DateTimeKind.Local).AddTicks(5011), "InStock", "Perferendis sint repudiandae necessitatibus debitis provident. Eos nemo rerum velit et aspernatur. Ipsa sed ullam quaerat architecto. Rerum nihil ducimus sequi in.", "Product 736", "XS", "Outerwear" },
                    { 737, new DateTime(2020, 9, 5, 10, 38, 58, 27, DateTimeKind.Local).AddTicks(8550), "InStock", "Praesentium qui quaerat adipisci amet tenetur rerum numquam eveniet. Quia fugiat tempora sint. Quos unde natus veniam nulla. Ut eius dolore consequatur. Est est nemo laboriosam vel est.", "Product 737", "M", "Underwear" },
                    { 738, new DateTime(2020, 7, 3, 10, 38, 58, 28, DateTimeKind.Local).AddTicks(2540), "OutStock", "Veritatis est nam libero odio pariatur laudantium sint quam. Fugiat sed inventore quas minus magni molestiae fugit. Perferendis non laudantium et tempora temporibus cumque sit. Quae nostrum quidem atque similique distinctio eum ut.", "Product 738", "S", "Outerwear" },
                    { 739, new DateTime(2020, 6, 28, 10, 38, 58, 28, DateTimeKind.Local).AddTicks(6463), "OutStock", "Repellendus tempora eaque ea quae corporis corporis necessitatibus. Magni amet dolores aperiam et aut alias aliquid asperiores. Enim impedit earum enim eligendi. Illo doloremque fugit vitae consequatur ea vel magni qui.", "Product 739", "S", "Footwear" },
                    { 740, new DateTime(2020, 8, 27, 10, 38, 58, 28, DateTimeKind.Local).AddTicks(8296), "OutStock", "Molestiae fuga sit consequuntur. Fuga dolores quidem quisquam praesentium. Voluptatem non eos voluptatem dolores soluta sunt quia.", "Product 740", "XS", "Accessory" },
                    { 741, new DateTime(2020, 7, 19, 10, 38, 58, 29, DateTimeKind.Local).AddTicks(1100), "InStock", "Possimus consequatur optio quo earum ut dolorem. Voluptates qui libero sunt non quia eius. Sequi non mollitia atque quae voluptatem aut at ut. Cupiditate quisquam aliquid laudantium.", "Product 741", "XS", "Underwear" },
                    { 742, new DateTime(2020, 9, 17, 10, 38, 58, 29, DateTimeKind.Local).AddTicks(3799), "InStock", "Deserunt reprehenderit voluptate assumenda quis blanditiis ullam. Labore quisquam esse fuga. Non animi est itaque. Iure cupiditate doloribus sint iure ratione alias. Sunt sit consequatur alias.", "Product 742", "L", "Underwear" },
                    { 743, new DateTime(2020, 8, 14, 10, 38, 58, 29, DateTimeKind.Local).AddTicks(5615), "InStock", "Provident in provident ab quibusdam voluptatum. Possimus odit aut sed. Eius vel sint quos natus quis.", "Product 743", "L", "Outerwear" },
                    { 744, new DateTime(2020, 9, 18, 10, 38, 58, 29, DateTimeKind.Local).AddTicks(7731), "OutStock", "Rem neque laborum qui vel a illo. Officia nulla accusantium ex nesciunt ut et. Dolore quos asperiores omnis tenetur dolores.", "Product 744", "S", "Outerwear" },
                    { 745, new DateTime(2020, 8, 6, 10, 38, 58, 30, DateTimeKind.Local).AddTicks(169), "InStock", "Quod cumque tenetur dolore qui voluptatem. Consequuntur eaque culpa sint. Iure rerum sit possimus similique ut explicabo porro. Suscipit reiciendis ut quia omnis.", "Product 745", "S", "Footwear" },
                    { 746, new DateTime(2020, 9, 11, 10, 38, 58, 30, DateTimeKind.Local).AddTicks(1907), "InStock", "Excepturi illo deleniti qui. Omnis cum quo quam temporibus eos libero consequatur. Qui et vel dolor.", "Product 746", "S", "Underwear" },
                    { 747, new DateTime(2020, 8, 7, 10, 38, 58, 30, DateTimeKind.Local).AddTicks(4166), "InStock", "Et mollitia iure fuga aliquid reprehenderit eum beatae eius. Incidunt inventore rerum similique corporis dolor repudiandae hic. Nostrum similique necessitatibus commodi.", "Product 747", "S", "Accessory" },
                    { 748, new DateTime(2020, 6, 27, 10, 38, 58, 30, DateTimeKind.Local).AddTicks(5961), "OutStock", "Excepturi ut eius voluptatem blanditiis. Quos ut quibusdam sunt eius aut. Omnis asperiores vitae eum aut.", "Product 748", "S", "Accessory" },
                    { 721, new DateTime(2020, 8, 12, 10, 38, 58, 20, DateTimeKind.Local).AddTicks(9995), "OutStock", "Ex delectus dolore labore unde ut sunt autem repellat. Ut alias rem velit quis ad nemo voluptas aut. Dicta possimus explicabo beatae ut. Ut sit voluptas cum. Repudiandae earum odit non nemo.", "Product 721", "XS", "Outerwear" },
                    { 720, new DateTime(2020, 7, 13, 10, 38, 58, 20, DateTimeKind.Local).AddTicks(3098), "OutStock", "Dolore alias dicta ducimus optio et sed neque illum. Vero blanditiis voluptatibus qui earum. Non et et modi. Impedit non ut atque reiciendis unde in id dolores.", "Product 720", "S", "Accessory" },
                    { 719, new DateTime(2020, 6, 21, 10, 38, 58, 19, DateTimeKind.Local).AddTicks(7421), "InStock", "Ratione sit modi in non. Ut sunt debitis voluptatem. Optio qui placeat perferendis recusandae est repudiandae dolor.", "Product 719", "L", "Outerwear" },
                    { 718, new DateTime(2020, 7, 18, 10, 38, 58, 19, DateTimeKind.Local).AddTicks(4069), "InStock", "Iusto non similique qui quis possimus delectus iste. Sapiente et qui consequatur cum. Quo ut ea ut modi rerum quibusdam. Iure saepe quos nesciunt omnis consequatur. Labore quo harum aut occaecati autem.", "Product 718", "L", "Outerwear" },
                    { 690, new DateTime(2020, 6, 25, 10, 38, 58, 5, DateTimeKind.Local).AddTicks(4423), "OutStock", "Qui fugiat harum tenetur rerum. Corporis aut voluptatum repellat voluptas. Magnam qui eos aut aliquam impedit.", "Product 690", "M", "Outerwear" },
                    { 691, new DateTime(2020, 7, 3, 10, 38, 58, 5, DateTimeKind.Local).AddTicks(8413), "InStock", "Numquam nemo unde veritatis vel exercitationem cupiditate. Dolore blanditiis odit quia dolore mollitia inventore enim vel. Magnam et et quaerat sed veritatis voluptates voluptatem iusto.", "Product 691", "S", "Outerwear" },
                    { 692, new DateTime(2020, 9, 18, 10, 38, 58, 6, DateTimeKind.Local).AddTicks(3135), "OutStock", "Provident quia dolorem placeat voluptas omnis. Ea placeat harum dicta dignissimos voluptatem laudantium eum. Dolore voluptatibus sit est sunt. Aut alias est occaecati et in ut. Et sapiente maiores nulla voluptatem.", "Product 692", "XS", "Outerwear" },
                    { 693, new DateTime(2020, 9, 2, 10, 38, 58, 6, DateTimeKind.Local).AddTicks(6446), "InStock", "Blanditiis consequatur quae rerum explicabo sit eligendi alias provident. Quos sunt velit ea excepturi saepe. Suscipit soluta alias provident nulla expedita.", "Product 693", "M", "Outerwear" },
                    { 694, new DateTime(2020, 7, 25, 10, 38, 58, 7, DateTimeKind.Local).AddTicks(131), "InStock", "Repellat omnis modi porro doloribus quia magnam. Sit corporis minima repellendus. Voluptas saepe in laborum voluptatem. Accusamus consequuntur quia voluptas voluptas velit consequatur a.", "Product 694", "L", "Footwear" },
                    { 695, new DateTime(2020, 9, 13, 10, 38, 58, 7, DateTimeKind.Local).AddTicks(4730), "InStock", "Ut sit quod et a aut laboriosam. Tempora excepturi et saepe eveniet alias odit nobis. Consequatur dolor vitae aliquid blanditiis occaecati quos deleniti quo. Ad quam error exercitationem tempore.", "Product 695", "XS", "Footwear" },
                    { 696, new DateTime(2020, 8, 17, 10, 38, 58, 7, DateTimeKind.Local).AddTicks(8035), "InStock", "Maiores qui qui cupiditate nisi nulla amet ut. Voluptas necessitatibus facere quasi. Corporis laboriosam quo sed. Occaecati consectetur qui sit laboriosam.", "Product 696", "L", "Outerwear" },
                    { 697, new DateTime(2020, 7, 2, 10, 38, 58, 8, DateTimeKind.Local).AddTicks(2419), "InStock", "Voluptas incidunt minus blanditiis perferendis molestias magnam. Aliquid qui fugit ratione quidem vel itaque. Dolor dolorum voluptate impedit. Est assumenda ipsa error. Necessitatibus molestias eos autem eum ab commodi.", "Product 697", "M", "Outerwear" },
                    { 698, new DateTime(2020, 8, 12, 10, 38, 58, 8, DateTimeKind.Local).AddTicks(5146), "OutStock", "Quod sed expedita ut distinctio. Veniam ab et eligendi rem sequi. Suscipit et autem incidunt et consequuntur.", "Product 698", "L", "Outerwear" },
                    { 699, new DateTime(2020, 7, 11, 10, 38, 58, 8, DateTimeKind.Local).AddTicks(9242), "InStock", "Velit cupiditate harum reprehenderit. Voluptatum voluptatem quaerat id facilis. Fugit voluptatibus beatae autem consequatur dolor et voluptatem. Iste ut rerum corporis voluptate rerum ea sunt.", "Product 699", "XS", "Accessory" },
                    { 700, new DateTime(2020, 9, 3, 10, 38, 58, 9, DateTimeKind.Local).AddTicks(2663), "InStock", "Et voluptatum nam ipsam. Quod quaerat sint porro occaecati ipsa. Ea necessitatibus possimus voluptates tempora qui. Necessitatibus nobis distinctio exercitationem dolore blanditiis.", "Product 700", "S", "Accessory" },
                    { 701, new DateTime(2020, 6, 25, 10, 38, 58, 9, DateTimeKind.Local).AddTicks(7861), "InStock", "Nam modi ad nisi sit. Quos porro vero consequuntur similique animi dolor. Facere sunt quia vel fuga maiores officia sed dolor. Quo nobis eligendi quia quia tenetur dolores consequuntur. Non odio aut ducimus nulla voluptatem.", "Product 701", "L", "Footwear" },
                    { 702, new DateTime(2020, 9, 9, 10, 38, 58, 10, DateTimeKind.Local).AddTicks(2565), "OutStock", "Eius cupiditate natus placeat. Enim nulla ut iure. Vel ipsam et vel aut sunt vitae qui quisquam. Laborum adipisci non illum omnis aut voluptatum corporis optio. Consectetur voluptatem mollitia dolores facilis.", "Product 702", "L", "Outerwear" },
                    { 627, new DateTime(2020, 8, 27, 10, 38, 57, 981, DateTimeKind.Local).AddTicks(5738), "InStock", "Excepturi autem voluptas dicta aperiam. Qui dignissimos ut non placeat. Placeat natus ratione voluptatem. Accusantium similique corrupti ut dolores qui est. Voluptate ea repellat aut et.", "Product 627", "L", "Underwear" },
                    { 703, new DateTime(2020, 6, 25, 10, 38, 58, 10, DateTimeKind.Local).AddTicks(6336), "OutStock", "Laboriosam autem et aut. Fuga eligendi ut placeat et maxime dignissimos. Est fuga itaque quam quam quia qui. Esse expedita occaecati nihil aliquam laborum.", "Product 703", "M", "Underwear" },
                    { 705, new DateTime(2020, 6, 26, 10, 38, 58, 13, DateTimeKind.Local).AddTicks(4726), "InStock", "Velit aut quia nesciunt dignissimos qui est mollitia. Sit pariatur reiciendis error amet. Dolores fugit atque at id officiis. Nisi alias maiores repellendus commodi.", "Product 705", "XS", "Underwear" },
                    { 706, new DateTime(2020, 8, 15, 10, 38, 58, 13, DateTimeKind.Local).AddTicks(9271), "OutStock", "Nobis error cum ea et. Dolores et qui quae aut tenetur natus amet. Expedita voluptas dolores eos sed. Praesentium aut facere enim.", "Product 706", "L", "Accessory" },
                    { 707, new DateTime(2020, 8, 14, 10, 38, 58, 14, DateTimeKind.Local).AddTicks(2673), "InStock", "Aut sunt soluta sequi sint fugiat. Enim similique voluptatem perferendis quisquam. Aut qui ea a nesciunt molestias tenetur iste maiores.", "Product 707", "L", "Outerwear" },
                    { 708, new DateTime(2020, 9, 18, 10, 38, 58, 14, DateTimeKind.Local).AddTicks(8089), "OutStock", "Aliquam et id voluptatem et dolore dolores. Quod non sed suscipit earum velit. Similique qui quia sed quia quia ut. Inventore eos explicabo nulla iste repudiandae fugiat et. Porro vero qui blanditiis consequatur aliquam.", "Product 708", "L", "Outerwear" },
                    { 709, new DateTime(2020, 6, 25, 10, 38, 58, 15, DateTimeKind.Local).AddTicks(2241), "OutStock", "Eius eum nobis dolore pariatur. Explicabo itaque repudiandae sit ex doloribus modi vero ipsa. Laborum harum sint et autem. Aperiam excepturi consectetur velit et dolores illum.", "Product 709", "XS", "Underwear" },
                    { 710, new DateTime(2020, 8, 14, 10, 38, 58, 15, DateTimeKind.Local).AddTicks(6489), "InStock", "Esse libero eum quia sed. Rerum qui optio nulla. Itaque corrupti vel velit. A ea itaque aut sunt et aut. Fugiat magnam officiis quia voluptatem aperiam.", "Product 710", "XS", "Underwear" },
                    { 711, new DateTime(2020, 8, 7, 10, 38, 58, 16, DateTimeKind.Local).AddTicks(1929), "OutStock", "Veritatis minus adipisci quia voluptatum maiores. Deserunt odit nulla ipsam veritatis tempore. Sed ut quia illum ut corrupti. Et odio eaque fugiat ut necessitatibus aut odit. Ipsa consequatur consequatur et quis ipsum velit ex aut.", "Product 711", "L", "Outerwear" },
                    { 712, new DateTime(2020, 7, 10, 10, 38, 58, 16, DateTimeKind.Local).AddTicks(7023), "OutStock", "Dolorem fuga aliquid quia praesentium illo sed consequatur in. Aut sint est dolorem quas. Minus saepe perspiciatis omnis provident ut consequatur quia. Fugit numquam asperiores odit ipsum et ut eveniet rerum.", "Product 712", "L", "Footwear" },
                    { 713, new DateTime(2020, 7, 24, 10, 38, 58, 17, DateTimeKind.Local).AddTicks(2952), "InStock", "Est atque quia sint illo. At ducimus voluptas ut earum odit dolorem cumque. Repudiandae vel deleniti vel repellendus ducimus delectus fugit deleniti. Eveniet sed autem est est enim nostrum perspiciatis. Error exercitationem quidem odit vitae in omnis voluptatem.", "Product 713", "S", "Accessory" },
                    { 714, new DateTime(2020, 8, 17, 10, 38, 58, 17, DateTimeKind.Local).AddTicks(7669), "OutStock", "Eveniet velit placeat quia quia nam iure. Impedit adipisci nostrum repudiandae debitis quisquam corrupti. Quasi aut nemo sit numquam sunt nesciunt explicabo. Dolorem quae ad dolores soluta excepturi quis perspiciatis.", "Product 714", "M", "Accessory" },
                    { 715, new DateTime(2020, 7, 5, 10, 38, 58, 18, DateTimeKind.Local).AddTicks(2620), "OutStock", "Itaque consectetur aut dolor. Voluptatibus cum debitis numquam harum. Voluptatibus quam voluptate omnis ut inventore sunt fugiat. Et nam molestiae nisi voluptatibus dolor. Odit eum fugit hic est qui aperiam ipsa.", "Product 715", "M", "Outerwear" },
                    { 716, new DateTime(2020, 6, 19, 10, 38, 58, 18, DateTimeKind.Local).AddTicks(5230), "InStock", "Sit ipsa ut architecto. Saepe non sunt voluptatem dolorem quia eos. Dolores voluptates et dolorum.", "Product 716", "L", "Accessory" },
                    { 717, new DateTime(2020, 7, 3, 10, 38, 58, 18, DateTimeKind.Local).AddTicks(9084), "InStock", "Repellendus dolor aspernatur provident repudiandae. Veniam sit neque rem commodi. Nulla mollitia eligendi consequatur qui fuga. Qui dolor et occaecati est enim sed repellat.", "Product 717", "L", "Accessory" },
                    { 704, new DateTime(2020, 8, 2, 10, 38, 58, 12, DateTimeKind.Local).AddTicks(5242), "OutStock", "Alias error sit ab enim accusamus. Nostrum repudiandae consequuntur cupiditate a qui. Alias harum quibusdam molestias dolorem et nesciunt quaerat.", "Product 704", "M", "Outerwear" },
                    { 749, new DateTime(2020, 7, 2, 10, 38, 58, 30, DateTimeKind.Local).AddTicks(8203), "OutStock", "Delectus cumque ratione aut optio. Ullam quia odio hic in expedita incidunt autem voluptas. Aliquid veniam eaque deserunt quibusdam sunt harum.", "Product 749", "XS", "Underwear" },
                    { 626, new DateTime(2020, 6, 18, 10, 38, 57, 981, DateTimeKind.Local).AddTicks(1758), "OutStock", "Et aut deserunt quibusdam sint reprehenderit. Repellendus rem id ut. Minus sunt non atque assumenda. Illum iusto laboriosam ab explicabo omnis aut placeat. Corrupti et sunt voluptatem et nostrum placeat suscipit dolores.", "Product 626", "S", "Footwear" },
                    { 624, new DateTime(2020, 6, 25, 10, 38, 57, 980, DateTimeKind.Local).AddTicks(3688), "OutStock", "Eaque ea voluptates distinctio quibusdam tenetur. Quos rem dolorum dolor provident explicabo est molestias nisi. Neque non perspiciatis et aperiam.", "Product 624", "L", "Accessory" },
                    { 534, new DateTime(2020, 6, 15, 10, 38, 57, 944, DateTimeKind.Local).AddTicks(2580), "InStock", "Provident excepturi laborum architecto omnis. Dolorum consectetur consequuntur rerum sit exercitationem. Ducimus modi cum dolorum animi et omnis. Eaque amet fuga dolorum.", "Product 534", "L", "Outerwear" },
                    { 535, new DateTime(2020, 9, 13, 10, 38, 57, 944, DateTimeKind.Local).AddTicks(5781), "OutStock", "Eius consequatur et rerum impedit quia. Tempora et velit perferendis molestiae qui quia numquam. Asperiores iure quam alias facere cum. Qui et repellat quos.", "Product 535", "XS", "Underwear" },
                    { 536, new DateTime(2020, 8, 10, 10, 38, 57, 945, DateTimeKind.Local).AddTicks(146), "InStock", "Quidem consequatur dolores officia sit est et. Saepe eius similique praesentium velit esse hic. Quas est iste et quo. Assumenda corrupti assumenda sed veniam. Perspiciatis nam itaque eaque eligendi explicabo quia quo et.", "Product 536", "M", "Accessory" },
                    { 537, new DateTime(2020, 7, 30, 10, 38, 57, 945, DateTimeKind.Local).AddTicks(3272), "OutStock", "Dolore perferendis molestias quis et esse sit. Vero alias debitis corrupti occaecati odit velit ut. Odit magni eveniet fugiat. Impedit illum dolor nobis.", "Product 537", "S", "Footwear" },
                    { 538, new DateTime(2020, 8, 16, 10, 38, 57, 945, DateTimeKind.Local).AddTicks(6126), "OutStock", "Fuga in illum veniam id. Quibusdam sit veritatis harum. Officiis quia facilis quasi error vitae consequatur voluptatem. Occaecati tempora aut id.", "Product 538", "L", "Outerwear" },
                    { 539, new DateTime(2020, 6, 22, 10, 38, 57, 945, DateTimeKind.Local).AddTicks(9655), "InStock", "Sint adipisci sit quod. Inventore qui atque minus aut perspiciatis amet. Debitis deleniti et debitis nisi corporis. Consequuntur maxime maiores incidunt minima adipisci veritatis et pariatur.", "Product 539", "XS", "Accessory" },
                    { 540, new DateTime(2020, 7, 21, 10, 38, 57, 946, DateTimeKind.Local).AddTicks(3767), "OutStock", "Ratione omnis aut suscipit ut veniam dolorem tempora accusantium. Vel rerum tempore deserunt eius ipsa in maxime. Ut error cupiditate assumenda natus. Quam sint ad cum. Libero illo sint esse deleniti.", "Product 540", "XS", "Accessory" },
                    { 541, new DateTime(2020, 6, 24, 10, 38, 57, 946, DateTimeKind.Local).AddTicks(7333), "OutStock", "Soluta aut debitis et aut. Aut illum doloremque quaerat consequatur cum consectetur. Est veritatis velit cupiditate et. Tenetur aut esse repellat tenetur iste veniam est laborum.", "Product 541", "S", "Underwear" },
                    { 542, new DateTime(2020, 8, 31, 10, 38, 57, 947, DateTimeKind.Local).AddTicks(926), "InStock", "Ipsum et inventore consectetur. Omnis commodi consectetur maxime sit quibusdam odio est optio. Reiciendis id enim et enim laborum quaerat. Dolorem aut nostrum amet eum quia quod.", "Product 542", "M", "Accessory" },
                    { 543, new DateTime(2020, 8, 2, 10, 38, 57, 947, DateTimeKind.Local).AddTicks(4955), "OutStock", "Eos ex quasi quod voluptatem enim enim iure aut. Dicta eaque iusto nam nulla nihil dignissimos ea. Nulla et numquam earum perferendis. Cupiditate at architecto eaque et fugiat quis tempora.", "Product 543", "M", "Accessory" },
                    { 544, new DateTime(2020, 9, 14, 10, 38, 57, 947, DateTimeKind.Local).AddTicks(8984), "InStock", "Corrupti inventore recusandae est. Itaque accusantium autem blanditiis debitis iusto. Velit voluptate asperiores asperiores et maiores velit. Maxime consequatur occaecati possimus accusamus rerum ea reprehenderit consectetur.", "Product 544", "XS", "Underwear" },
                    { 545, new DateTime(2020, 9, 12, 10, 38, 57, 948, DateTimeKind.Local).AddTicks(4269), "InStock", "Voluptatum ut aut ipsum reprehenderit possimus velit officiis. Autem sed enim consectetur officiis quas et delectus exercitationem. Mollitia consectetur autem aut est recusandae distinctio molestias adipisci. Quibusdam magnam dolorum quod aspernatur. Atque et dolorem suscipit quis.", "Product 545", "XS", "Underwear" },
                    { 546, new DateTime(2020, 8, 21, 10, 38, 57, 948, DateTimeKind.Local).AddTicks(6899), "InStock", "Eos voluptatibus id dolores sit. Et distinctio ad itaque omnis hic. Doloremque excepturi sint voluptate doloremque.", "Product 546", "M", "Underwear" },
                    { 547, new DateTime(2020, 7, 26, 10, 38, 57, 949, DateTimeKind.Local).AddTicks(1786), "InStock", "Sunt autem repellat sit quia consequuntur. Eos dolores error eos facilis est. Esse adipisci corporis vel sit et id temporibus. Ad dolorem ea pariatur quis labore. Magni minus quo explicabo rerum quia.", "Product 547", "XS", "Outerwear" },
                    { 548, new DateTime(2020, 7, 10, 10, 38, 57, 949, DateTimeKind.Local).AddTicks(5456), "OutStock", "Similique et aut magnam praesentium recusandae ut et illum. Temporibus animi harum officia earum omnis inventore enim nihil. Eveniet culpa atque ut sit earum.", "Product 548", "M", "Accessory" },
                    { 549, new DateTime(2020, 6, 26, 10, 38, 57, 950, DateTimeKind.Local).AddTicks(575), "InStock", "Velit asperiores assumenda dolorum maiores iure velit eum. Delectus nostrum vel et facilis aliquid. Amet provident quo impedit quaerat eius temporibus cumque aut. Quas fuga reprehenderit praesentium nemo in. Quo tempora non placeat mollitia.", "Product 549", "XS", "Outerwear" },
                    { 550, new DateTime(2020, 7, 4, 10, 38, 57, 950, DateTimeKind.Local).AddTicks(4839), "OutStock", "Et tempora placeat rerum perferendis deserunt consequuntur sit explicabo. Possimus magni quo magni. Laborum qui tempora accusantium inventore. Facere debitis debitis tempora expedita accusantium. Labore blanditiis laborum rem.", "Product 550", "M", "Underwear" },
                    { 551, new DateTime(2020, 7, 11, 10, 38, 57, 950, DateTimeKind.Local).AddTicks(8826), "InStock", "Voluptatem sunt ea repudiandae dignissimos dolor dolorum corrupti repudiandae. Distinctio deleniti sed quis. Non et numquam in laboriosam velit. Ab modi fuga impedit dolorem velit omnis.", "Product 551", "XS", "Footwear" },
                    { 552, new DateTime(2020, 8, 26, 10, 38, 57, 951, DateTimeKind.Local).AddTicks(3219), "InStock", "Nisi autem ut nisi perspiciatis ratione hic est qui. Maxime aperiam qui culpa pariatur beatae consequatur corrupti. Aut nobis asperiores voluptatem. Quia cumque est magni. Qui tenetur sint modi.", "Product 552", "XS", "Outerwear" },
                    { 553, new DateTime(2020, 7, 17, 10, 38, 57, 951, DateTimeKind.Local).AddTicks(6850), "InStock", "Qui blanditiis rerum cumque. Maxime voluptatem sed voluptatem. Non animi vel aut tenetur cumque laborum. At itaque autem repellat deserunt exercitationem aut quam.", "Product 553", "L", "Accessory" },
                    { 554, new DateTime(2020, 8, 11, 10, 38, 57, 952, DateTimeKind.Local).AddTicks(1482), "OutStock", "Non molestiae vero qui quo voluptas iure. Quas ut quia sed pariatur est sed est. Id occaecati accusantium cumque quasi. Sit sit cum incidunt nisi ipsam eos. Et ad magnam tempore.", "Product 554", "L", "Accessory" },
                    { 555, new DateTime(2020, 9, 1, 10, 38, 57, 952, DateTimeKind.Local).AddTicks(6677), "InStock", "Omnis quas dolores consectetur fuga ut ratione sint. Eos sit modi harum dolorem similique. Optio aut omnis aut inventore totam molestias. Mollitia dolores rerum quia ipsam rerum et voluptatibus qui. Repudiandae omnis et consequatur delectus.", "Product 555", "L", "Accessory" },
                    { 556, new DateTime(2020, 6, 18, 10, 38, 57, 953, DateTimeKind.Local).AddTicks(985), "OutStock", "Atque ipsa nihil laudantium qui consequuntur ut consequatur voluptatibus. Dolorem nesciunt ut est. Voluptates qui molestiae nostrum quaerat tempore. Porro aut iure inventore minus unde et sit perferendis.", "Product 556", "M", "Footwear" },
                    { 557, new DateTime(2020, 6, 14, 10, 38, 57, 953, DateTimeKind.Local).AddTicks(3860), "InStock", "Aut asperiores assumenda perspiciatis dolores tenetur eaque. Reprehenderit voluptatem magnam suscipit nihil. Vel neque molestiae occaecati non quis.", "Product 557", "S", "Underwear" },
                    { 558, new DateTime(2020, 6, 27, 10, 38, 57, 953, DateTimeKind.Local).AddTicks(7475), "OutStock", "Velit officiis consequatur at explicabo repellat. Praesentium ipsam ipsa aliquam quisquam rerum quia alias. Dolor a inventore fuga beatae qui laborum occaecati ut.", "Product 558", "M", "Footwear" },
                    { 559, new DateTime(2020, 9, 18, 10, 38, 57, 954, DateTimeKind.Local).AddTicks(719), "InStock", "Ab aliquam consequatur laboriosam officia explicabo est. Qui ea et et voluptatibus fugit non rerum. Nisi quod placeat labore enim dolores.", "Product 559", "L", "Footwear" },
                    { 560, new DateTime(2020, 9, 2, 10, 38, 57, 954, DateTimeKind.Local).AddTicks(3659), "OutStock", "Deleniti delectus suscipit possimus et. Ut possimus et expedita et. Perspiciatis eveniet reiciendis mollitia. Dolorem odit officia libero.", "Product 560", "L", "Underwear" },
                    { 533, new DateTime(2020, 8, 30, 10, 38, 57, 943, DateTimeKind.Local).AddTicks(9532), "InStock", "Consequatur consequatur sunt esse sapiente quasi illo. Labore est hic et aliquid qui eos dolor sint. Aperiam quia rerum aut.", "Product 533", "XS", "Outerwear" },
                    { 561, new DateTime(2020, 7, 20, 10, 38, 57, 954, DateTimeKind.Local).AddTicks(9395), "InStock", "Et error consectetur tempora perferendis dolor est ipsam ullam. Et cumque aut officiis quae. Sint tempora necessitatibus aut ut enim sit id. Tenetur et eum accusamus quis eligendi placeat et maiores. Neque molestias commodi repellendus architecto.", "Product 561", "XS", "Outerwear" },
                    { 532, new DateTime(2020, 7, 10, 10, 38, 57, 943, DateTimeKind.Local).AddTicks(6690), "InStock", "Aliquid magni est quisquam. Impedit qui ipsum impedit quas aliquid accusamus animi. Aperiam natus non tempore quis dolorem sit. Tempora qui error debitis voluptatem aut qui ut.", "Product 532", "S", "Underwear" },
                    { 530, new DateTime(2020, 6, 27, 10, 38, 57, 943, DateTimeKind.Local).AddTicks(263), "InStock", "Nihil ad iste aperiam ullam vero. Non quasi consequatur enim sapiente sed eius. Ipsam voluptates ex nihil et totam nostrum. Deleniti amet debitis sed omnis aut nihil illo.", "Product 530", "S", "Underwear" },
                    { 503, new DateTime(2020, 7, 28, 10, 38, 57, 934, DateTimeKind.Local).AddTicks(1930), "OutStock", "Animi molestias architecto eaque aperiam voluptatem non itaque quasi. Maiores consequatur omnis velit dolor explicabo corrupti et voluptatibus. Qui rerum consequatur dolor et et at. Aperiam voluptates porro enim asperiores maxime.", "Product 503", "M", "Outerwear" },
                    { 504, new DateTime(2020, 8, 30, 10, 38, 57, 934, DateTimeKind.Local).AddTicks(4054), "InStock", "Sit inventore asperiores recusandae sapiente. Autem porro non omnis. Error quae officia et est suscipit a assumenda et.", "Product 504", "L", "Outerwear" },
                    { 505, new DateTime(2020, 7, 20, 10, 38, 57, 934, DateTimeKind.Local).AddTicks(7681), "OutStock", "Distinctio in occaecati quis omnis eius quasi asperiores. Pariatur velit rerum rerum eum enim. Amet sed consequatur tempora aspernatur. Ipsam sed quisquam ut et sapiente quae. Delectus sit cupiditate similique autem alias.", "Product 505", "XS", "Accessory" },
                    { 506, new DateTime(2020, 6, 20, 10, 38, 57, 934, DateTimeKind.Local).AddTicks(9794), "InStock", "Molestias cupiditate voluptas recusandae et dolor expedita. Sed temporibus rerum consequatur vel corporis voluptas. Et est animi odio.", "Product 506", "S", "Underwear" },
                    { 507, new DateTime(2020, 7, 17, 10, 38, 57, 935, DateTimeKind.Local).AddTicks(4250), "OutStock", "Animi quae dolor fuga rem ipsa earum quidem. Quos praesentium numquam reprehenderit beatae provident. Ea vel dolorum repudiandae non ipsam et non architecto. Rerum accusamus dolores earum consequuntur earum quia ducimus reiciendis. Animi eaque maxime sequi et autem voluptatem voluptatum omnis.", "Product 507", "XS", "Accessory" },
                    { 508, new DateTime(2020, 6, 17, 10, 38, 57, 935, DateTimeKind.Local).AddTicks(7564), "InStock", "In dolor vel velit officia ut dolores aut qui. Soluta veritatis et ut et. Voluptatem commodi ipsa occaecati alias dolorem. Minima in et natus. Sint atque autem saepe id.", "Product 508", "XS", "Footwear" },
                    { 509, new DateTime(2020, 9, 9, 10, 38, 57, 936, DateTimeKind.Local).AddTicks(1328), "InStock", "Voluptatem vitae quos voluptas earum qui. Et ut nisi labore nihil maxime. Reiciendis qui error explicabo sunt magni harum. Aliquam sed ut voluptates ea dolores quaerat dignissimos. Voluptatibus eaque ut hic officia quam consequatur.", "Product 509", "XS", "Underwear" },
                    { 510, new DateTime(2020, 9, 18, 10, 38, 57, 936, DateTimeKind.Local).AddTicks(4728), "InStock", "Sunt non tempora nihil rem fuga rem. Accusantium fugiat maxime harum repudiandae doloribus. Amet qui dolorem provident. Doloribus voluptas accusamus sit ut ullam esse totam. Aut quod sit alias porro.", "Product 510", "M", "Accessory" },
                    { 511, new DateTime(2020, 9, 15, 10, 38, 57, 936, DateTimeKind.Local).AddTicks(8075), "InStock", "Earum illo fuga est qui. Soluta magni debitis et magnam molestiae sit aut. Voluptatem quasi voluptas iure voluptas facilis. Sit est voluptates et et. Esse doloribus voluptas cupiditate suscipit.", "Product 511", "S", "Accessory" },
                    { 512, new DateTime(2020, 8, 19, 10, 38, 57, 937, DateTimeKind.Local).AddTicks(382), "InStock", "Nemo voluptatem sit necessitatibus. Perspiciatis maxime corrupti sed ipsam aut. Voluptatem et sunt et voluptate occaecati in beatae cumque.", "Product 512", "L", "Outerwear" },
                    { 513, new DateTime(2020, 6, 22, 10, 38, 57, 937, DateTimeKind.Local).AddTicks(3332), "InStock", "Dicta aperiam ut ducimus autem ipsum ut. Est ut voluptas et eaque eligendi. Id quo corrupti natus molestiae. Doloremque ut quam quas necessitatibus esse quod suscipit.", "Product 513", "XS", "Footwear" },
                    { 514, new DateTime(2020, 9, 16, 10, 38, 57, 937, DateTimeKind.Local).AddTicks(7282), "InStock", "Deserunt et ea ullam officia velit quo molestias. Inventore quis eos illo omnis dolore provident. Dolores aliquid unde quas officiis aut at. At nulla quo saepe asperiores ut ducimus cum. Id reprehenderit voluptas dolorem neque.", "Product 514", "L", "Footwear" },
                    { 515, new DateTime(2020, 6, 24, 10, 38, 57, 938, DateTimeKind.Local).AddTicks(1362), "OutStock", "Nemo voluptatem et iusto porro laudantium consequatur ad. Ducimus est architecto maiores in alias alias. Similique vel praesentium cupiditate architecto. Sit inventore ut nisi aspernatur maiores ullam ab. Quia cupiditate praesentium nihil accusantium architecto et itaque deleniti.", "Product 515", "L", "Outerwear" },
                    { 516, new DateTime(2020, 9, 8, 10, 38, 57, 938, DateTimeKind.Local).AddTicks(4535), "OutStock", "Dolores velit temporibus consectetur. Asperiores voluptatem amet voluptatem nihil dolorum voluptatem porro. Optio ab voluptas facere voluptas quisquam consequatur voluptas et. Dolor ut dolore sint eligendi autem commodi.", "Product 516", "L", "Outerwear" },
                    { 517, new DateTime(2020, 6, 23, 10, 38, 57, 938, DateTimeKind.Local).AddTicks(7942), "InStock", "Omnis non atque aliquid praesentium sint. Voluptates earum assumenda aliquam aut mollitia velit consectetur. Perspiciatis culpa fuga recusandae ea dignissimos. Ut veritatis corporis voluptatem et.", "Product 517", "S", "Outerwear" },
                    { 518, new DateTime(2020, 8, 15, 10, 38, 57, 939, DateTimeKind.Local).AddTicks(1466), "InStock", "Et aut quia voluptatem aut saepe doloremque. Maxime architecto magni dolorem accusantium veniam. Earum ipsam fuga eum. Repellendus qui blanditiis sit ad facilis sunt est quia.", "Product 518", "XS", "Accessory" },
                    { 519, new DateTime(2020, 8, 23, 10, 38, 57, 939, DateTimeKind.Local).AddTicks(4003), "InStock", "Ut laudantium voluptas laudantium nobis odit. Fugiat voluptatibus voluptatem quo laudantium. Molestiae et aut neque ex laboriosam et.", "Product 519", "S", "Accessory" },
                    { 520, new DateTime(2020, 8, 20, 10, 38, 57, 939, DateTimeKind.Local).AddTicks(6498), "InStock", "Iure ut adipisci voluptas. At qui ut quis eius ab sit eum quas. Iusto fuga molestias omnis quidem.", "Product 520", "S", "Outerwear" },
                    { 521, new DateTime(2020, 6, 18, 10, 38, 57, 939, DateTimeKind.Local).AddTicks(9191), "InStock", "Qui nihil accusantium voluptatem eveniet. Nobis sunt ea deleniti tenetur repudiandae voluptates et. Sit et nihil distinctio natus velit.", "Product 521", "M", "Underwear" },
                    { 522, new DateTime(2020, 6, 25, 10, 38, 57, 940, DateTimeKind.Local).AddTicks(3517), "OutStock", "Vel at repudiandae nobis saepe natus. Eos assumenda occaecati at ducimus cupiditate. Qui libero molestiae qui architecto aut pariatur. Occaecati omnis sed at sit eveniet consequuntur. Provident magni sapiente atque error perspiciatis ut.", "Product 522", "L", "Outerwear" },
                    { 523, new DateTime(2020, 7, 15, 10, 38, 57, 940, DateTimeKind.Local).AddTicks(7717), "InStock", "Ipsam quod voluptatem labore et qui voluptatum. Eum velit doloribus aut ut dolor hic dolorum. Ipsa quibusdam et et veniam laboriosam ut et. Laudantium voluptas doloribus dolor repellat aliquid vel itaque est.", "Product 523", "M", "Accessory" },
                    { 524, new DateTime(2020, 7, 12, 10, 38, 57, 941, DateTimeKind.Local).AddTicks(334), "OutStock", "Ut temporibus minima perferendis fugiat quasi. Voluptatem expedita et quia mollitia. Quidem delectus repellat sed quia molestiae unde facere.", "Product 524", "M", "Footwear" },
                    { 525, new DateTime(2020, 8, 31, 10, 38, 57, 941, DateTimeKind.Local).AddTicks(4567), "InStock", "Dolore sit voluptates repudiandae. Qui rerum a sint. Voluptas impedit voluptatibus vero sapiente nulla nisi velit accusantium. Velit consequatur consequatur eveniet qui eius illum ut nesciunt. Ducimus ullam assumenda et quibusdam nemo.", "Product 525", "S", "Accessory" },
                    { 526, new DateTime(2020, 8, 5, 10, 38, 57, 941, DateTimeKind.Local).AddTicks(7148), "OutStock", "Aperiam minus sit et neque at optio ipsa. Itaque voluptates perferendis voluptatem optio. Et et laudantium dicta neque.", "Product 526", "M", "Accessory" },
                    { 527, new DateTime(2020, 8, 19, 10, 38, 57, 942, DateTimeKind.Local).AddTicks(1424), "OutStock", "Eius qui dolores sint sunt et rerum. Nihil eos sit velit eius vel. Accusantium illo illum velit. Inventore perspiciatis est officiis reiciendis sit impedit sit quos. Voluptatem voluptas qui molestias occaecati delectus.", "Product 527", "M", "Accessory" },
                    { 528, new DateTime(2020, 7, 9, 10, 38, 57, 942, DateTimeKind.Local).AddTicks(3596), "InStock", "Consequatur ipsa et dolores omnis. Omnis maiores odit vero velit. Eveniet voluptatem non molestiae autem.", "Product 528", "S", "Accessory" },
                    { 529, new DateTime(2020, 7, 6, 10, 38, 57, 942, DateTimeKind.Local).AddTicks(6502), "OutStock", "Officia voluptatem natus molestiae. Suscipit nam pariatur quia consequatur. Laborum qui sit magnam. Qui est aspernatur dignissimos quasi voluptas dolore eos.", "Product 529", "S", "Footwear" },
                    { 531, new DateTime(2020, 8, 12, 10, 38, 57, 943, DateTimeKind.Local).AddTicks(3112), "OutStock", "Ea qui modi cumque. Quaerat voluptatem earum sed et dolorum temporibus voluptate. Non eligendi perferendis temporibus omnis dolores provident quis molestiae.", "Product 531", "XS", "Underwear" },
                    { 562, new DateTime(2020, 6, 20, 10, 38, 57, 955, DateTimeKind.Local).AddTicks(4192), "OutStock", "Sed distinctio aut voluptas eum tempore natus corrupti. Exercitationem molestias consequatur ut fugiat sunt sit enim ratione. Quas id non quam eos ut repudiandae quae maiores. Assumenda fuga ut sed enim dolor.", "Product 562", "S", "Footwear" },
                    { 563, new DateTime(2020, 8, 30, 10, 38, 57, 955, DateTimeKind.Local).AddTicks(9854), "InStock", "Reprehenderit sunt quam quae sequi et at perspiciatis. Cumque quae facilis dignissimos placeat et qui quos quae. Modi aut quam dignissimos sed repellat aspernatur porro sequi. Eius atque quo quis voluptas delectus facilis. Ex nesciunt voluptatem quisquam atque.", "Product 563", "S", "Footwear" },
                    { 564, new DateTime(2020, 8, 25, 10, 38, 57, 956, DateTimeKind.Local).AddTicks(2856), "InStock", "Doloribus vel rerum eum. Est sunt impedit autem unde quo alias magni. Consequuntur tempora quo est dolores dolores temporibus.", "Product 564", "S", "Underwear" },
                    { 597, new DateTime(2020, 6, 12, 10, 38, 57, 969, DateTimeKind.Local).AddTicks(9904), "OutStock", "Porro aut et maxime ut magnam quis. Ea delectus voluptatem quia minima blanditiis ex et minima. Ullam quia ea corporis voluptate commodi quis. Nemo deleniti minus voluptates sit omnis numquam.", "Product 597", "S", "Outerwear" },
                    { 598, new DateTime(2020, 8, 27, 10, 38, 57, 970, DateTimeKind.Local).AddTicks(4626), "InStock", "Repellat velit eum at necessitatibus eius. Cumque ea quia corporis culpa illum aliquid error. Exercitationem dignissimos voluptatum voluptate eveniet doloremque est amet incidunt. Soluta ea eum dolore ut ab enim ea vero.", "Product 598", "S", "Footwear" },
                    { 599, new DateTime(2020, 8, 7, 10, 38, 57, 970, DateTimeKind.Local).AddTicks(7566), "OutStock", "Non aut quasi non quis. Iure et est molestiae labore expedita accusantium aut cupiditate. Quia modi quisquam dolor.", "Product 599", "XS", "Outerwear" },
                    { 600, new DateTime(2020, 7, 6, 10, 38, 57, 971, DateTimeKind.Local).AddTicks(2037), "OutStock", "Nam vel et sapiente ut accusantium id a distinctio. Quis non ea earum. Facere aut accusamus perspiciatis pariatur qui eos dolorem voluptatibus. Rerum rem quam esse accusamus excepturi voluptatum.", "Product 600", "S", "Underwear" },
                    { 601, new DateTime(2020, 9, 2, 10, 38, 57, 971, DateTimeKind.Local).AddTicks(6322), "InStock", "Et omnis qui qui et. Eveniet sit officia nam qui harum ut quod atque. Dolorem repellat tempore similique dolores quos. Amet neque id repellat. Maiores ex qui nisi.", "Product 601", "L", "Underwear" },
                    { 602, new DateTime(2020, 7, 18, 10, 38, 57, 972, DateTimeKind.Local).AddTicks(289), "InStock", "Similique sunt mollitia qui. Enim excepturi assumenda suscipit iure. Quos sint asperiores quo consequatur consequatur qui pariatur. Doloremque accusantium totam voluptatum ipsa sapiente natus quia ea.", "Product 602", "L", "Accessory" },
                    { 603, new DateTime(2020, 7, 8, 10, 38, 57, 972, DateTimeKind.Local).AddTicks(5023), "InStock", "Explicabo nemo minus voluptatibus. Rerum consequuntur voluptatem quia vitae rerum quo consequatur voluptatem. Deserunt necessitatibus modi sit voluptas distinctio nihil. Eum assumenda est ut. Et aut dicta quas ab blanditiis ad.", "Product 603", "S", "Footwear" },
                    { 604, new DateTime(2020, 8, 12, 10, 38, 57, 972, DateTimeKind.Local).AddTicks(7648), "OutStock", "Quia dolorem perferendis quam. Totam veniam esse ut velit. Qui ut sunt rerum est quisquam vitae.", "Product 604", "M", "Footwear" },
                    { 605, new DateTime(2020, 9, 1, 10, 38, 57, 973, DateTimeKind.Local).AddTicks(1198), "OutStock", "Neque cumque itaque odit velit similique possimus et. Est quas ut autem. Minus animi placeat et quia sunt. Maiores hic dolorem aut doloremque.", "Product 605", "L", "Underwear" },
                    { 606, new DateTime(2020, 9, 3, 10, 38, 57, 973, DateTimeKind.Local).AddTicks(6407), "OutStock", "Laudantium sit velit recusandae nulla dolorem vel qui. Omnis facere inventore sunt repellat tempore pariatur. Saepe ea voluptatem distinctio. In nostrum dolor molestiae qui velit fuga porro. Est deleniti labore autem qui dolore aut ipsum.", "Product 606", "S", "Footwear" },
                    { 607, new DateTime(2020, 7, 4, 10, 38, 57, 974, DateTimeKind.Local).AddTicks(671), "OutStock", "In unde aut adipisci in vel eos. Voluptate recusandae dolorem repellat et. Quidem eos expedita et dolor ut itaque. Doloribus sit nisi perspiciatis autem atque ipsa enim magnam.", "Product 607", "M", "Accessory" },
                    { 608, new DateTime(2020, 6, 14, 10, 38, 57, 974, DateTimeKind.Local).AddTicks(4228), "InStock", "Quis omnis illo eos. Officia rerum quidem culpa ea facilis est. Minima quo sapiente ratione quisquam assumenda id. Fugit quia quos est possimus.", "Product 608", "L", "Outerwear" },
                    { 609, new DateTime(2020, 6, 16, 10, 38, 57, 974, DateTimeKind.Local).AddTicks(8675), "InStock", "Modi sit doloremque qui cumque impedit quos. Minima suscipit libero asperiores voluptatibus aliquid fugiat voluptatem dignissimos. Amet aut doloremque qui dicta aliquam. Exercitationem nesciunt et et sint doloremque minus.", "Product 609", "L", "Accessory" },
                    { 610, new DateTime(2020, 8, 8, 10, 38, 57, 975, DateTimeKind.Local).AddTicks(4040), "OutStock", "Iure vel quidem accusamus ab quas sit. Quaerat deserunt aut ut. Sequi nostrum et error et cumque occaecati quo non. Incidunt est et ut voluptatem omnis reprehenderit. Dolorem est vitae reiciendis a quia ea alias repellat.", "Product 610", "L", "Underwear" },
                    { 611, new DateTime(2020, 7, 26, 10, 38, 57, 975, DateTimeKind.Local).AddTicks(7261), "OutStock", "Voluptate animi iusto veniam ea quia magni. Libero veniam soluta maiores provident aut dolor voluptas et. Nobis quidem tempore nostrum.", "Product 611", "M", "Footwear" },
                    { 612, new DateTime(2020, 8, 13, 10, 38, 57, 976, DateTimeKind.Local).AddTicks(1782), "OutStock", "Odio voluptatum eligendi nihil libero sed earum. Rerum beatae voluptates iure eos dolor maiores recusandae. Eius et facere possimus voluptate eum sed sit. Non odit quaerat eum nam sit iure.", "Product 612", "S", "Accessory" },
                    { 613, new DateTime(2020, 8, 28, 10, 38, 57, 976, DateTimeKind.Local).AddTicks(4892), "OutStock", "Perspiciatis aut impedit qui. Nisi nulla aut corporis laborum accusantium non non aut. Quia repellat suscipit quo et ex laborum.", "Product 613", "XS", "Underwear" },
                    { 614, new DateTime(2020, 9, 8, 10, 38, 57, 976, DateTimeKind.Local).AddTicks(7996), "OutStock", "Inventore ducimus et sunt suscipit laborum. Veritatis quam id et harum est. Est assumenda nulla tempora autem rerum non.", "Product 614", "L", "Outerwear" },
                    { 615, new DateTime(2020, 8, 24, 10, 38, 57, 977, DateTimeKind.Local).AddTicks(1706), "InStock", "Deleniti quo corporis praesentium. Illo repellendus quae mollitia et ea necessitatibus. Id reprehenderit odit vero vel eum reprehenderit. Praesentium consectetur quis quia vel quia.", "Product 615", "S", "Outerwear" },
                    { 616, new DateTime(2020, 9, 18, 10, 38, 57, 977, DateTimeKind.Local).AddTicks(4720), "InStock", "Consequatur ut ipsum pariatur illum tenetur modi autem aspernatur. Nobis delectus omnis doloribus illum. Voluptas iste nemo nostrum soluta.", "Product 616", "L", "Underwear" },
                    { 617, new DateTime(2020, 9, 14, 10, 38, 57, 977, DateTimeKind.Local).AddTicks(7911), "OutStock", "Ratione id odit asperiores laboriosam deserunt sint odio. Provident eos earum saepe ipsum ullam totam. Dolores qui nobis a fuga.", "Product 617", "L", "Outerwear" },
                    { 618, new DateTime(2020, 8, 28, 10, 38, 57, 978, DateTimeKind.Local).AddTicks(2231), "InStock", "Voluptas enim corporis placeat sapiente. Esse eos magnam aperiam iste ad. Dolores repudiandae aut non et aperiam asperiores facilis. Voluptas molestiae minus molestiae nam. Quia est voluptates qui.", "Product 618", "XS", "Accessory" },
                    { 619, new DateTime(2020, 9, 8, 10, 38, 57, 978, DateTimeKind.Local).AddTicks(6056), "OutStock", "Sequi dolor suscipit ea id. Eum et animi ipsum totam magnam perspiciatis ipsam qui. Eligendi minima adipisci assumenda. Dolores qui nihil aspernatur sint provident consequatur.", "Product 619", "L", "Footwear" },
                    { 620, new DateTime(2020, 8, 3, 10, 38, 57, 978, DateTimeKind.Local).AddTicks(8942), "InStock", "Vel cumque aperiam blanditiis hic expedita amet dicta alias. Explicabo consectetur dolor aut quibusdam. Quos consequatur aliquid sed.", "Product 620", "XS", "Footwear" },
                    { 621, new DateTime(2020, 8, 25, 10, 38, 57, 979, DateTimeKind.Local).AddTicks(3003), "InStock", "Velit modi provident et qui facere consectetur iusto sed. In debitis sed odit. Possimus delectus in ex saepe ut quis explicabo esse. Vel sint iste impedit fugiat.", "Product 621", "S", "Footwear" },
                    { 622, new DateTime(2020, 8, 20, 10, 38, 57, 979, DateTimeKind.Local).AddTicks(7161), "OutStock", "Eos alias voluptatem qui nulla iste. Nam corrupti officia amet numquam. Ut omnis aspernatur a sint aut eum quam doloribus. Ea molestiae quo et dolores minima ut.", "Product 622", "L", "Accessory" },
                    { 623, new DateTime(2020, 9, 5, 10, 38, 57, 980, DateTimeKind.Local).AddTicks(546), "InStock", "Consequuntur nihil ea aliquam vero natus est. Numquam magnam ipsa qui ut laborum perspiciatis. Ex quia neque iure officiis quo accusantium voluptas.", "Product 623", "L", "Outerwear" },
                    { 596, new DateTime(2020, 6, 16, 10, 38, 57, 969, DateTimeKind.Local).AddTicks(5325), "InStock", "Voluptatum id et quos quos ab aspernatur est non. Nostrum quia ex tempore doloremque ut omnis. Quae dolores voluptatem sunt exercitationem et ut consequuntur. Quia voluptatum error consectetur labore.", "Product 596", "XS", "Accessory" },
                    { 595, new DateTime(2020, 6, 12, 10, 38, 57, 969, DateTimeKind.Local).AddTicks(869), "InStock", "Minus debitis officia ex tenetur dignissimos beatae quo. Eius sint porro et eum natus. Excepturi non sed accusamus nobis. Rerum necessitatibus facilis sit accusantium.", "Product 595", "M", "Accessory" },
                    { 594, new DateTime(2020, 7, 8, 10, 38, 57, 968, DateTimeKind.Local).AddTicks(7185), "InStock", "Quis maiores aut placeat fugiat labore. Repellat tempore voluptatem nisi odit hic iste quisquam quis. Voluptatem sint voluptates est dolorem laborum perspiciatis illo. Omnis enim et voluptatem aut qui praesentium totam. Sint quo aut qui sed et rerum.", "Product 594", "M", "Accessory" },
                    { 593, new DateTime(2020, 8, 17, 10, 38, 57, 968, DateTimeKind.Local).AddTicks(1598), "OutStock", "Voluptas ex voluptatem est vero blanditiis sint repellat quia. Cupiditate sunt perspiciatis debitis sed sit commodi distinctio enim. Sed rem eum magnam id recusandae. Nihil vel temporibus unde eaque quia nulla aperiam ratione.", "Product 593", "L", "Accessory" },
                    { 565, new DateTime(2020, 7, 19, 10, 38, 57, 956, DateTimeKind.Local).AddTicks(4929), "OutStock", "Dicta assumenda quaerat dolorem. Laboriosam sed explicabo hic. Nemo temporibus est voluptatibus.", "Product 565", "XS", "Outerwear" },
                    { 566, new DateTime(2020, 8, 18, 10, 38, 57, 957, DateTimeKind.Local).AddTicks(634), "OutStock", "Voluptas illum repellendus corporis illo sit saepe. Fugit maxime aut ipsam ea veniam ipsa non dolores. Quia occaecati eveniet aut enim. Consequatur sunt aperiam recusandae optio odit ut et. Quasi et sunt et voluptatem quia doloremque aliquid dolor.", "Product 566", "L", "Outerwear" },
                    { 567, new DateTime(2020, 9, 7, 10, 38, 57, 957, DateTimeKind.Local).AddTicks(5706), "OutStock", "Repellendus sed est quibusdam modi sit quo dolor omnis. Rerum voluptas ea sapiente praesentium enim ducimus iste aliquam. Nulla eum et quaerat unde doloremque. Ut dolorum ut est iusto. Quam quibusdam autem vero impedit.", "Product 567", "XS", "Accessory" },
                    { 568, new DateTime(2020, 6, 19, 10, 38, 57, 958, DateTimeKind.Local).AddTicks(115), "InStock", "Officia ipsa rerum corporis temporibus qui. Vero aut iusto accusantium explicabo debitis numquam. Minus error in porro vero totam nihil sapiente. Et fuga qui velit quod quibusdam ipsam dolores.", "Product 568", "S", "Outerwear" },
                    { 569, new DateTime(2020, 6, 14, 10, 38, 57, 958, DateTimeKind.Local).AddTicks(3537), "InStock", "Consequuntur dolorum autem qui error voluptas culpa sint quidem. Tenetur cum ut aut accusantium quidem cum hic natus. Laudantium odit iure autem.", "Product 569", "M", "Outerwear" },
                    { 570, new DateTime(2020, 8, 2, 10, 38, 57, 958, DateTimeKind.Local).AddTicks(7083), "InStock", "Expedita pariatur cupiditate modi necessitatibus esse voluptatem rem possimus. Delectus et molestias qui numquam omnis mollitia consequatur. Explicabo distinctio facere nihil quas.", "Product 570", "L", "Outerwear" },
                    { 571, new DateTime(2020, 7, 21, 10, 38, 57, 959, DateTimeKind.Local).AddTicks(1289), "InStock", "Eum ullam vero expedita labore id consequatur fugit vero. Ullam perferendis earum nostrum eum optio explicabo. Asperiores nam impedit consectetur ad sit odit. Unde porro neque aut deleniti.", "Product 571", "M", "Footwear" },
                    { 572, new DateTime(2020, 7, 26, 10, 38, 57, 959, DateTimeKind.Local).AddTicks(5226), "OutStock", "Et et molestiae cumque quia harum veniam. Voluptate dicta possimus perspiciatis vel commodi quisquam. Eum dignissimos nisi sed explicabo. Perferendis voluptatem voluptatibus sed cupiditate quae ut.", "Product 572", "L", "Accessory" },
                    { 573, new DateTime(2020, 8, 4, 10, 38, 57, 959, DateTimeKind.Local).AddTicks(9784), "InStock", "Neque est dolore ipsam qui sint sapiente praesentium eveniet. Laudantium ipsam voluptates eos et minima pariatur. Quo officiis omnis aut ex eos et. Necessitatibus voluptatem corporis error molestiae sunt consequuntur.", "Product 573", "M", "Outerwear" },
                    { 574, new DateTime(2020, 7, 15, 10, 38, 57, 960, DateTimeKind.Local).AddTicks(4440), "OutStock", "Ipsa quod est quos occaecati rerum et. Exercitationem voluptatem ut ut rerum. Corporis qui asperiores praesentium. Atque eveniet quisquam rerum consequuntur voluptatibus qui. Voluptatem sit ut aut odit voluptatem minima perspiciatis.", "Product 574", "XS", "Underwear" },
                    { 575, new DateTime(2020, 8, 7, 10, 38, 57, 960, DateTimeKind.Local).AddTicks(9164), "InStock", "Necessitatibus quae minima nostrum cupiditate repellendus dolorem sed dolor. Numquam quia aut incidunt error quaerat ut. Et eum est corporis et est. Tenetur eius illum libero veniam cupiditate corrupti sint et.", "Product 575", "XS", "Underwear" },
                    { 576, new DateTime(2020, 7, 6, 10, 38, 57, 961, DateTimeKind.Local).AddTicks(3043), "InStock", "Dolor quod nisi aut iusto. Sit ea iste error. Laborum sed et et aut aliquam modi ratione natus. Enim eos autem ipsa eos ut et.", "Product 576", "M", "Outerwear" },
                    { 577, new DateTime(2020, 8, 12, 10, 38, 57, 961, DateTimeKind.Local).AddTicks(6893), "OutStock", "Harum assumenda officiis facilis id aut voluptates. Debitis quibusdam sint quas et quia in ex nam. Fugit eaque est officia nisi sed atque praesentium qui.", "Product 577", "M", "Outerwear" },
                    { 625, new DateTime(2020, 9, 13, 10, 38, 57, 980, DateTimeKind.Local).AddTicks(6990), "OutStock", "Quia dolorem laboriosam excepturi rerum nisi laboriosam quos nihil. Rerum voluptas optio natus nobis perferendis eum. Quam molestiae a et sunt.", "Product 625", "XS", "Outerwear" },
                    { 578, new DateTime(2020, 7, 20, 10, 38, 57, 962, DateTimeKind.Local).AddTicks(1012), "InStock", "Enim dolor accusamus laborum accusamus sunt quo quo non. Dignissimos quia labore similique ut praesentium non. Ut temporibus minus quae quasi. Vel praesentium dolor iusto molestiae possimus.", "Product 578", "L", "Footwear" },
                    { 580, new DateTime(2020, 6, 21, 10, 38, 57, 962, DateTimeKind.Local).AddTicks(7973), "InStock", "Iusto minima eveniet ratione. Distinctio dolor ipsam quia quia recusandae. Voluptatem fuga sunt quia et. Dolores sit alias vitae. Soluta modi accusantium ipsam reiciendis a autem.", "Product 580", "M", "Outerwear" },
                    { 581, new DateTime(2020, 6, 21, 10, 38, 57, 963, DateTimeKind.Local).AddTicks(2698), "OutStock", "Suscipit quidem fuga atque voluptas dolorum neque sunt. Quo quod ut aut voluptatum in voluptates omnis esse. Magnam ratione vel placeat quis quam voluptate. Sunt beatae sint aperiam aperiam sint doloremque mollitia.", "Product 581", "XS", "Outerwear" },
                    { 582, new DateTime(2020, 7, 21, 10, 38, 57, 963, DateTimeKind.Local).AddTicks(5865), "InStock", "Eos soluta eaque rerum ipsam nostrum. Aut non quasi blanditiis a sit non. Est sed quia distinctio illo adipisci minus.", "Product 582", "L", "Outerwear" },
                    { 583, new DateTime(2020, 6, 24, 10, 38, 57, 964, DateTimeKind.Local).AddTicks(798), "InStock", "Dignissimos quisquam sapiente quia labore quidem dolor deserunt. Corrupti iure aliquid minima similique nostrum facilis tempore omnis. Ut et at omnis autem odit qui culpa animi. Magnam porro veniam sapiente quis quos quis.", "Product 583", "XS", "Footwear" },
                    { 584, new DateTime(2020, 6, 14, 10, 38, 57, 964, DateTimeKind.Local).AddTicks(3449), "OutStock", "Et quia est fugiat itaque deleniti eos. Ad voluptas ea perspiciatis. Assumenda fuga nihil sit dolor.", "Product 584", "XS", "Footwear" },
                    { 585, new DateTime(2020, 9, 5, 10, 38, 57, 964, DateTimeKind.Local).AddTicks(8944), "InStock", "Voluptatem nihil excepturi et culpa voluptatem odio. Officia aspernatur provident laboriosam sapiente eos est aut a. Nesciunt culpa ab aut saepe odit eveniet perferendis. Eveniet explicabo excepturi id cumque corporis. Vitae sed voluptas tenetur reprehenderit fugiat a.", "Product 585", "S", "Footwear" },
                    { 586, new DateTime(2020, 9, 4, 10, 38, 57, 965, DateTimeKind.Local).AddTicks(1557), "InStock", "Repellendus et natus nobis. Necessitatibus rerum et ab consequuntur fugit. Voluptatum voluptate adipisci incidunt dignissimos beatae.", "Product 586", "XS", "Outerwear" },
                    { 587, new DateTime(2020, 9, 11, 10, 38, 57, 965, DateTimeKind.Local).AddTicks(4064), "OutStock", "Similique odit eaque repellendus. Cum explicabo asperiores ad aut magnam. Aliquam asperiores blanditiis magnam accusamus.", "Product 587", "S", "Outerwear" },
                    { 588, new DateTime(2020, 6, 30, 10, 38, 57, 965, DateTimeKind.Local).AddTicks(9755), "OutStock", "Velit quam suscipit tempora ratione perspiciatis et occaecati natus. Voluptate consequatur officia dolorum voluptatibus. Qui ratione officia quia et nam. Autem sed sunt omnis nam rerum ex unde dignissimos. Et repudiandae quod labore et perspiciatis laudantium in placeat.", "Product 588", "XS", "Underwear" },
                    { 589, new DateTime(2020, 7, 3, 10, 38, 57, 966, DateTimeKind.Local).AddTicks(4984), "OutStock", "Earum id ipsa quasi placeat ut. Mollitia nisi accusantium minus suscipit assumenda. Aliquam iusto voluptates cupiditate et expedita. Perferendis eligendi quis esse ea debitis et voluptatem pariatur. Incidunt architecto provident sit nemo ea rerum omnis.", "Product 589", "M", "Footwear" },
                    { 590, new DateTime(2020, 9, 7, 10, 38, 57, 966, DateTimeKind.Local).AddTicks(7624), "InStock", "Eos sit alias inventore blanditiis. Et pariatur ipsam accusantium ut suscipit aut. Id omnis incidunt animi.", "Product 590", "L", "Footwear" },
                    { 591, new DateTime(2020, 8, 8, 10, 38, 57, 967, DateTimeKind.Local).AddTicks(1090), "OutStock", "Voluptatum nemo sunt modi ipsum. Modi animi eos architecto quasi. Accusamus assumenda qui cupiditate. Dolorum pariatur est porro laborum dolores ut consectetur.", "Product 591", "L", "Outerwear" },
                    { 592, new DateTime(2020, 7, 14, 10, 38, 57, 967, DateTimeKind.Local).AddTicks(6661), "OutStock", "Est voluptas dolor qui. Fugit delectus laudantium voluptatem aut odio dolorem aliquam suscipit. Quam dolorum sapiente necessitatibus atque error dolore est. Minus magni et et quia dignissimos ut minus. Ut sunt rerum et perspiciatis enim corrupti qui quia.", "Product 592", "M", "Outerwear" },
                    { 579, new DateTime(2020, 7, 19, 10, 38, 57, 962, DateTimeKind.Local).AddTicks(3893), "InStock", "Id fugit quis officiis veniam. Sit voluptatum deleniti quos ut debitis vel voluptatum. Atque odio nesciunt voluptatem vel.", "Product 579", "L", "Accessory" },
                    { 502, new DateTime(2020, 7, 18, 10, 38, 57, 933, DateTimeKind.Local).AddTicks(8456), "OutStock", "Accusamus laborum ex quibusdam exercitationem. Excepturi sed vitae quaerat non sunt. Quasi quod corporis sit. Id quam quia qui similique.", "Product 502", "S", "Accessory" },
                    { 750, new DateTime(2020, 9, 6, 10, 38, 58, 31, DateTimeKind.Local).AddTicks(634), "InStock", "Asperiores reiciendis aut rem. Maxime aut architecto repellat. Hic magnam minus assumenda aliquam sequi minima rerum. Incidunt ab neque ullam voluptas et hic.", "Product 750", "L", "Underwear" },
                    { 752, new DateTime(2020, 9, 2, 10, 38, 58, 31, DateTimeKind.Local).AddTicks(6799), "OutStock", "Qui qui aperiam quibusdam porro non eligendi asperiores sit. Corrupti nostrum rerum nisi accusantium nobis totam. In voluptas beatae mollitia quis eius quo et non. Accusantium voluptas corporis dolorum eum voluptas eum dolore. Ipsam et voluptate quia omnis repudiandae et.", "Product 752", "S", "Footwear" },
                    { 909, new DateTime(2020, 8, 30, 10, 38, 58, 69, DateTimeKind.Local).AddTicks(8949), "InStock", "Debitis illo dolore vero. In error id et corrupti dolores. Neque qui quo iusto voluptatibus quae hic voluptas nulla. Iusto porro molestiae consequuntur veniam aut veniam quo. A temporibus est deserunt ea perferendis ut reprehenderit.", "Product 909", "XS", "Footwear" },
                    { 910, new DateTime(2020, 8, 21, 10, 38, 58, 70, DateTimeKind.Local).AddTicks(2103), "OutStock", "Suscipit tempora reprehenderit magni exercitationem ut et labore. Omnis velit numquam ut quos rerum possimus quisquam nostrum. Repellat incidunt quia voluptatem voluptatem quia eius omnis. Non non tempore quis. Vitae tempora quis debitis quis non.", "Product 910", "M", "Accessory" },
                    { 911, new DateTime(2020, 8, 19, 10, 38, 58, 70, DateTimeKind.Local).AddTicks(3938), "OutStock", "Qui sint eius est sunt officiis. Id explicabo ab ut aliquam. Libero minus dolore doloribus provident eum quaerat impedit.", "Product 911", "M", "Footwear" },
                    { 912, new DateTime(2020, 7, 4, 10, 38, 58, 70, DateTimeKind.Local).AddTicks(6260), "OutStock", "Et sit debitis inventore maiores sit. Sapiente alias voluptatem officia possimus nihil officia in accusamus. Quis non incidunt atque voluptatem. At voluptas ut laudantium at.", "Product 912", "M", "Footwear" },
                    { 913, new DateTime(2020, 7, 18, 10, 38, 58, 70, DateTimeKind.Local).AddTicks(8671), "InStock", "Provident incidunt quae est labore vero quos soluta suscipit. Earum reiciendis enim quod. In deserunt omnis sequi aperiam qui consequatur officia beatae. Doloremque repellendus occaecati assumenda.", "Product 913", "M", "Underwear" },
                    { 914, new DateTime(2020, 8, 13, 10, 38, 58, 71, DateTimeKind.Local).AddTicks(1498), "OutStock", "Aut repudiandae ratione nisi sunt et eveniet veniam. Omnis repellat perferendis sunt rerum ex qui repudiandae quo. Facilis nemo natus rem ut sequi quia quos. Neque vitae dolores exercitationem explicabo nihil voluptate.", "Product 914", "M", "Footwear" },
                    { 915, new DateTime(2020, 7, 2, 10, 38, 58, 71, DateTimeKind.Local).AddTicks(3344), "InStock", "Consequatur ut in et officia sint ducimus voluptatem. Quibusdam earum blanditiis et eos saepe quasi vel. Ut sint ea rerum.", "Product 915", "S", "Outerwear" },
                    { 916, new DateTime(2020, 6, 15, 10, 38, 58, 71, DateTimeKind.Local).AddTicks(5837), "InStock", "Tempora quo sunt omnis quis ipsa illo. Natus sunt necessitatibus enim recusandae. Et sequi distinctio sit possimus aut. Sed vel quibusdam et provident aperiam laudantium nesciunt enim.", "Product 916", "L", "Footwear" },
                    { 917, new DateTime(2020, 9, 6, 10, 38, 58, 71, DateTimeKind.Local).AddTicks(7902), "OutStock", "Dolore cupiditate occaecati architecto nostrum est voluptatem veniam at. Sequi sed nihil esse iure odit incidunt accusantium dignissimos. Hic consequuntur sint eligendi.", "Product 917", "S", "Outerwear" },
                    { 918, new DateTime(2020, 7, 4, 10, 38, 58, 71, DateTimeKind.Local).AddTicks(9695), "OutStock", "Deserunt cupiditate rerum commodi delectus omnis unde quia. Optio facilis doloremque nam voluptas consequuntur. Numquam modi enim consequuntur perferendis.", "Product 918", "S", "Footwear" },
                    { 919, new DateTime(2020, 6, 30, 10, 38, 58, 72, DateTimeKind.Local).AddTicks(1102), "InStock", "Fugiat molestias suscipit ab. Aut mollitia maiores eaque. Quia rerum dolores voluptate corporis tempore.", "Product 919", "L", "Underwear" },
                    { 920, new DateTime(2020, 6, 23, 10, 38, 58, 72, DateTimeKind.Local).AddTicks(3324), "OutStock", "Et dolorem et eaque dolore aut illo quo repellendus. Exercitationem facere harum maxime mollitia vel doloribus sed qui. Dolor et exercitationem necessitatibus sunt distinctio.", "Product 920", "S", "Underwear" },
                    { 921, new DateTime(2020, 9, 16, 10, 38, 58, 72, DateTimeKind.Local).AddTicks(5427), "OutStock", "Quasi dolores temporibus voluptatem iusto tempora officiis et consequatur. Soluta quos velit sint dignissimos cumque. Distinctio nam quod omnis harum saepe officia.", "Product 921", "XS", "Outerwear" },
                    { 922, new DateTime(2020, 8, 18, 10, 38, 58, 72, DateTimeKind.Local).AddTicks(7809), "OutStock", "Ipsum quod enim vitae eligendi necessitatibus nisi voluptatibus. Et error et velit. Illum perferendis quos dolores sint quia. Rerum dolorem laborum totam ex nulla non nisi.", "Product 922", "M", "Outerwear" },
                    { 923, new DateTime(2020, 7, 16, 10, 38, 58, 73, DateTimeKind.Local).AddTicks(868), "InStock", "Dignissimos non ipsa beatae adipisci reprehenderit nihil officiis. Sapiente repudiandae explicabo sapiente. Ut sequi qui autem unde. Voluptatem saepe rerum id quisquam itaque dolores repellat. Debitis cupiditate aliquid voluptatum repellat et atque ut non.", "Product 923", "XS", "Footwear" },
                    { 924, new DateTime(2020, 7, 22, 10, 38, 58, 73, DateTimeKind.Local).AddTicks(3619), "OutStock", "Nam qui vel unde beatae optio perferendis. Sint corporis ab non deleniti officia ut quas non. Qui et sit aut. Tempore qui qui dolorem at fugiat. Doloribus quos porro nihil.", "Product 924", "S", "Accessory" },
                    { 925, new DateTime(2020, 8, 4, 10, 38, 58, 73, DateTimeKind.Local).AddTicks(5921), "OutStock", "Suscipit maxime officia rem. Animi quisquam voluptas incidunt ea quaerat velit id. Temporibus nesciunt sit hic sed. Eligendi ipsa illum nostrum id suscipit placeat officia.", "Product 925", "M", "Underwear" },
                    { 926, new DateTime(2020, 8, 15, 10, 38, 58, 73, DateTimeKind.Local).AddTicks(8889), "InStock", "Qui voluptate laudantium rem quibusdam beatae velit facilis doloribus. Quidem qui vel dolores laboriosam hic vel exercitationem. Ipsum porro non voluptatem sed eligendi sed et. Dicta repudiandae tenetur eius et dolor magni autem.", "Product 926", "S", "Accessory" },
                    { 927, new DateTime(2020, 8, 5, 10, 38, 58, 74, DateTimeKind.Local).AddTicks(959), "OutStock", "Temporibus in magni et est. Ullam dolores qui alias tempore necessitatibus tempora maxime eos. Magnam minus occaecati aut natus et nihil sed.", "Product 927", "M", "Footwear" },
                    { 928, new DateTime(2020, 9, 1, 10, 38, 58, 74, DateTimeKind.Local).AddTicks(4322), "OutStock", "Officiis atque qui aliquam inventore deserunt in. Voluptatum veniam excepturi sit consequuntur ut quia odio est. Eum nihil eum quisquam suscipit maiores. Voluptatem enim optio inventore facere et sit fugit. Aut perferendis voluptatem et aliquam.", "Product 928", "S", "Outerwear" },
                    { 929, new DateTime(2020, 7, 15, 10, 38, 58, 74, DateTimeKind.Local).AddTicks(7045), "InStock", "Quae voluptas eos saepe et deserunt amet rerum placeat. Odit et odit sapiente ut explicabo placeat odit. Rerum voluptatibus aspernatur expedita est modi et error sequi. Et et laborum quas.", "Product 929", "XS", "Underwear" },
                    { 930, new DateTime(2020, 6, 26, 10, 38, 58, 74, DateTimeKind.Local).AddTicks(8964), "InStock", "Laudantium aut commodi et consequatur voluptatem voluptatibus. Eaque in non nisi aut sequi consequatur pariatur vitae. Id nemo fugit voluptatem.", "Product 930", "S", "Accessory" },
                    { 931, new DateTime(2020, 7, 20, 10, 38, 58, 75, DateTimeKind.Local).AddTicks(821), "InStock", "Voluptates et ut perspiciatis. Dolorum tempore qui enim sit assumenda commodi. Voluptatem quasi necessitatibus enim voluptates dolor culpa rem.", "Product 931", "L", "Underwear" },
                    { 932, new DateTime(2020, 7, 30, 10, 38, 58, 75, DateTimeKind.Local).AddTicks(2573), "InStock", "Asperiores omnis mollitia odit nisi maiores aut. Culpa ut corporis quis consequatur voluptatem quod. Totam aut sit commodi.", "Product 932", "S", "Footwear" },
                    { 933, new DateTime(2020, 8, 19, 10, 38, 58, 75, DateTimeKind.Local).AddTicks(4809), "OutStock", "Perspiciatis hic ut deserunt ut quod ipsa cupiditate. Omnis est iste omnis libero vitae est. Porro sunt nihil tempore ut quaerat consectetur suscipit atque.", "Product 933", "L", "Accessory" },
                    { 934, new DateTime(2020, 9, 10, 10, 38, 58, 75, DateTimeKind.Local).AddTicks(7148), "InStock", "Tenetur perferendis ex quasi quisquam modi qui. Quasi illum aspernatur provident officiis dignissimos a eligendi rerum. Deleniti voluptate ipsam fugit in vel corporis qui et.", "Product 934", "XS", "Outerwear" },
                    { 935, new DateTime(2020, 6, 20, 10, 38, 58, 75, DateTimeKind.Local).AddTicks(9923), "OutStock", "Doloribus nobis iusto qui rerum aut. Architecto dolorem eos laudantium sunt ut. Ipsum omnis eaque et voluptate. Autem voluptatibus est ipsum cumque earum in dolor. Autem occaecati dolorem quia porro.", "Product 935", "S", "Outerwear" },
                    { 908, new DateTime(2020, 9, 3, 10, 38, 58, 69, DateTimeKind.Local).AddTicks(5792), "OutStock", "Blanditiis repudiandae qui minima ut culpa nesciunt sit totam. Ipsa velit nesciunt enim doloribus qui eos est. Explicabo qui quia corrupti dolorum et aut nulla. Sint officiis aliquid autem deserunt. Rerum dolores qui nihil.", "Product 908", "S", "Underwear" },
                    { 936, new DateTime(2020, 8, 9, 10, 38, 58, 76, DateTimeKind.Local).AddTicks(2764), "OutStock", "Praesentium expedita quos hic vel tempora minima. Quod porro provident eius sunt ea reprehenderit. Distinctio iusto quas iste alias ipsam sed et ut. Qui aliquid odio ut ea iure et fugiat est.", "Product 936", "M", "Underwear" },
                    { 907, new DateTime(2020, 7, 18, 10, 38, 58, 69, DateTimeKind.Local).AddTicks(2682), "OutStock", "Rerum est autem neque et veritatis. Rem autem minima officiis ut officia possimus esse molestiae. Neque rem consequuntur vel itaque.", "Product 907", "S", "Footwear" },
                    { 905, new DateTime(2020, 8, 24, 10, 38, 58, 68, DateTimeKind.Local).AddTicks(7444), "InStock", "Dignissimos enim dolores velit. A earum quae qui distinctio consequatur ipsa. Hic perferendis cumque blanditiis animi non quia earum. Sint delectus ut et sequi nemo culpa ut. Dolorem voluptas accusamus numquam quod omnis.", "Product 905", "XS", "Underwear" },
                    { 878, new DateTime(2020, 9, 5, 10, 38, 58, 62, DateTimeKind.Local).AddTicks(5077), "OutStock", "Aut sunt sed consequuntur tempora aut sunt neque nobis. Optio eaque iure ad id impedit. Eius natus quis quam animi voluptas facere aut. Rerum earum adipisci iste earum quia dolorem iure ea. Vel laboriosam repellendus temporibus quod dolores nisi ipsam et.", "Product 878", "XS", "Accessory" },
                    { 879, new DateTime(2020, 9, 14, 10, 38, 58, 62, DateTimeKind.Local).AddTicks(7571), "InStock", "Ullam nostrum in et et sit reprehenderit aliquam voluptatem. Voluptatum consequatur alias eaque et eaque. Ipsa cupiditate nihil repellendus esse quasi dolorem. Quis illum ipsam nobis quia.", "Product 879", "L", "Underwear" },
                    { 880, new DateTime(2020, 6, 17, 10, 38, 58, 62, DateTimeKind.Local).AddTicks(9144), "OutStock", "Sed vel quaerat sit. Illo sapiente sed facilis qui. Enim dolor quaerat autem velit numquam accusantium.", "Product 880", "XS", "Footwear" },
                    { 881, new DateTime(2020, 7, 27, 10, 38, 58, 63, DateTimeKind.Local).AddTicks(885), "OutStock", "Quia quod ab voluptatum. Maxime sint minima doloribus. Non qui delectus voluptas qui molestiae. Ipsam doloribus qui aut.", "Product 881", "M", "Underwear" },
                    { 882, new DateTime(2020, 9, 7, 10, 38, 58, 63, DateTimeKind.Local).AddTicks(2791), "InStock", "Dolore alias cumque quaerat voluptates ut assumenda nulla voluptatem. Aut quia possimus impedit dolorem. Earum laborum et ipsum similique velit.", "Product 882", "L", "Footwear" },
                    { 883, new DateTime(2020, 7, 25, 10, 38, 58, 63, DateTimeKind.Local).AddTicks(4700), "OutStock", "Magni ipsam est in est. Facilis eos voluptatem deleniti aut aut temporibus tempore ab. Rerum et eos minus aliquam quam.", "Product 883", "L", "Footwear" },
                    { 884, new DateTime(2020, 7, 20, 10, 38, 58, 63, DateTimeKind.Local).AddTicks(7194), "InStock", "Omnis eveniet iure et sit. Facilis debitis doloremque possimus voluptatibus enim. Aspernatur velit sed neque vero atque consequatur. Quam nulla repudiandae repellat illum laboriosam ut sequi non.", "Product 884", "M", "Outerwear" },
                    { 885, new DateTime(2020, 8, 26, 10, 38, 58, 63, DateTimeKind.Local).AddTicks(9163), "OutStock", "Ut earum corrupti qui corporis. Magnam in rerum dicta consequatur et libero consequatur itaque. Iusto et qui et illo et officiis.", "Product 885", "S", "Accessory" },
                    { 886, new DateTime(2020, 8, 26, 10, 38, 58, 64, DateTimeKind.Local).AddTicks(1069), "OutStock", "Qui ratione nobis fuga. Porro quis voluptas magnam saepe asperiores ad. Optio quisquam vero corrupti nihil est aut cumque vel.", "Product 886", "S", "Footwear" },
                    { 887, new DateTime(2020, 6, 17, 10, 38, 58, 64, DateTimeKind.Local).AddTicks(2878), "InStock", "Dolorum non consequatur sequi et. Dignissimos et ab ipsum harum quia est quo consequatur. Quia nobis sed ut eius.", "Product 887", "S", "Accessory" },
                    { 888, new DateTime(2020, 7, 1, 10, 38, 58, 64, DateTimeKind.Local).AddTicks(5875), "InStock", "Et quo non repellat itaque architecto enim officia in. Quod iste voluptatem rerum. Esse harum deserunt blanditiis aut quo dolore. Modi quia fugiat tempore. Vel ut nulla et dolores recusandae et inventore veniam.", "Product 888", "M", "Footwear" },
                    { 889, new DateTime(2020, 7, 13, 10, 38, 58, 64, DateTimeKind.Local).AddTicks(7689), "InStock", "Quidem vero maiores deleniti eligendi ipsum repellendus temporibus. Temporibus eaque aperiam vitae quibusdam. Omnis et mollitia eligendi iure ratione.", "Product 889", "M", "Footwear" },
                    { 890, new DateTime(2020, 6, 25, 10, 38, 58, 65, DateTimeKind.Local).AddTicks(866), "OutStock", "Facere earum et consectetur deleniti facilis saepe eius. Laudantium excepturi reprehenderit facere. Repellendus omnis expedita recusandae dolore. Et ea aut reprehenderit dolorum qui sit voluptatem nam. Ut quam dicta eum libero in aut explicabo tempore.", "Product 890", "M", "Accessory" },
                    { 891, new DateTime(2020, 6, 30, 10, 38, 58, 65, DateTimeKind.Local).AddTicks(2906), "OutStock", "Et nemo voluptatum aut dolorum facere dolor. Quia odio dolorem quo doloremque magnam labore hic. Est voluptatem qui itaque possimus aspernatur quasi.", "Product 891", "XS", "Accessory" },
                    { 892, new DateTime(2020, 8, 29, 10, 38, 58, 65, DateTimeKind.Local).AddTicks(6049), "InStock", "Exercitationem est reiciendis recusandae reiciendis unde corporis magni. Odio modi reiciendis eos ullam possimus dolor ratione. Illum consequatur et consequatur vel. Libero voluptatem vel quo. Consequatur necessitatibus doloremque voluptas illo omnis in aspernatur veritatis.", "Product 892", "XS", "Underwear" },
                    { 893, new DateTime(2020, 8, 16, 10, 38, 58, 65, DateTimeKind.Local).AddTicks(8371), "OutStock", "Similique sequi enim quo sed. Et tempore necessitatibus mollitia qui et unde. Est laudantium magnam neque. Neque facilis velit illum. Quaerat non temporibus impedit.", "Product 893", "XS", "Accessory" },
                    { 894, new DateTime(2020, 8, 25, 10, 38, 58, 66, DateTimeKind.Local).AddTicks(361), "InStock", "Itaque dolores maiores sed id tempora deleniti. Voluptatem ut consequatur soluta similique est nemo maiores. Quasi deserunt necessitatibus voluptas dolorem incidunt.", "Product 894", "L", "Footwear" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Arrived", "Availability", "Description", "Name", "Size", "Type" },
                values: new object[,]
                {
                    { 895, new DateTime(2020, 7, 24, 10, 38, 58, 66, DateTimeKind.Local).AddTicks(2795), "InStock", "Facere aut quidem et magnam porro. Rem suscipit eum vitae a. Temporibus qui eos distinctio sunt non sit. Sint ut molestias porro aperiam quo alias sunt.", "Product 895", "L", "Underwear" },
                    { 896, new DateTime(2020, 9, 5, 10, 38, 58, 66, DateTimeKind.Local).AddTicks(5380), "OutStock", "Dolore cupiditate ipsa molestiae. Et quia et qui porro est corporis aperiam. Sit enim quae quas omnis tenetur ex. Rerum nobis eum alias illo quas quaerat ex a.", "Product 896", "L", "Outerwear" },
                    { 897, new DateTime(2020, 8, 10, 10, 38, 58, 66, DateTimeKind.Local).AddTicks(7033), "InStock", "Quae voluptas minima est culpa. Odit sapiente nemo repellat. Cum et reiciendis laudantium odit voluptatibus aut incidunt.", "Product 897", "S", "Underwear" },
                    { 898, new DateTime(2020, 9, 17, 10, 38, 58, 66, DateTimeKind.Local).AddTicks(9772), "InStock", "Saepe occaecati voluptatem dolore deleniti enim provident quam earum. Iusto nulla modi quia numquam. Et tempore aliquid dolores facere voluptas. Atque voluptatibus qui aut atque repellendus. Molestiae quis dolorum repellendus.", "Product 898", "S", "Outerwear" },
                    { 899, new DateTime(2020, 6, 29, 10, 38, 58, 67, DateTimeKind.Local).AddTicks(1504), "InStock", "Aut aspernatur enim et enim. Assumenda molestias ad totam magni fugit. Et repellendus id deleniti corporis qui voluptate.", "Product 899", "S", "Underwear" },
                    { 900, new DateTime(2020, 6, 16, 10, 38, 58, 67, DateTimeKind.Local).AddTicks(4691), "InStock", "Sed sit dolor nostrum eos et autem quia vitae. Voluptatem repellat veritatis sint provident officia in. Labore repudiandae dolores atque et esse et. Quis labore pariatur neque. Dolores sit occaecati ducimus pariatur ducimus explicabo sapiente.", "Product 900", "S", "Outerwear" },
                    { 901, new DateTime(2020, 9, 15, 10, 38, 58, 67, DateTimeKind.Local).AddTicks(7479), "InStock", "Facilis neque eius debitis quia molestiae illum. Quos velit debitis est sit incidunt incidunt est. Cum commodi autem tenetur qui in reprehenderit doloribus. Eius autem provident distinctio. Aliquam quam quia dolores.", "Product 901", "XS", "Outerwear" },
                    { 902, new DateTime(2020, 9, 5, 10, 38, 58, 67, DateTimeKind.Local).AddTicks(9556), "InStock", "Corporis vero qui amet eum. Laudantium voluptatem eveniet delectus velit. Omnis natus praesentium ea rerum. Autem nostrum voluptas nam iusto voluptas quia.", "Product 902", "XS", "Underwear" },
                    { 903, new DateTime(2020, 6, 20, 10, 38, 58, 68, DateTimeKind.Local).AddTicks(1894), "OutStock", "Non voluptas nisi dolores nisi consectetur vel consequatur et. Architecto consequuntur tempora soluta. Fugit illum accusantium ipsam consequuntur vel quis. Iusto a sit temporibus aut.", "Product 903", "L", "Footwear" },
                    { 904, new DateTime(2020, 6, 27, 10, 38, 58, 68, DateTimeKind.Local).AddTicks(4461), "InStock", "Quia necessitatibus rerum officiis. Id laboriosam dolor quia. Rerum ea perspiciatis eos totam veritatis. Reprehenderit reprehenderit eius voluptate sed ipsa enim necessitatibus laborum. Consequatur natus accusantium sit.", "Product 904", "S", "Accessory" },
                    { 906, new DateTime(2020, 6, 21, 10, 38, 58, 69, DateTimeKind.Local).AddTicks(788), "OutStock", "Corporis distinctio voluptatibus molestiae eveniet id dolore et numquam. Ducimus et quae sint quo illum odio. Nihil eos nihil enim assumenda eum dolore sit. Ducimus omnis consequatur tempore dolores qui. Odio id nihil explicabo facere vero nihil.", "Product 906", "L", "Accessory" },
                    { 937, new DateTime(2020, 8, 30, 10, 38, 58, 76, DateTimeKind.Local).AddTicks(5766), "OutStock", "Autem aut amet cum sit. Aliquam ipsam repudiandae consequatur sunt. Qui fugiat et aut magnam praesentium similique. Doloremque et dolor unde eos aut quas. Consequatur et facilis asperiores et beatae corporis sequi.", "Product 937", "M", "Underwear" },
                    { 938, new DateTime(2020, 7, 10, 10, 38, 58, 76, DateTimeKind.Local).AddTicks(7447), "InStock", "Non unde illum praesentium aut. Accusantium consectetur commodi dolor impedit rerum ducimus dolores. Dignissimos exercitationem suscipit quia.", "Product 938", "S", "Outerwear" },
                    { 939, new DateTime(2020, 8, 15, 10, 38, 58, 77, DateTimeKind.Local).AddTicks(330), "OutStock", "Corporis repellendus ut necessitatibus eius consequatur rerum. Quasi eligendi amet autem dolorem eos qui sed. Esse aliquid ipsum corrupti quis. Aspernatur odio dolorem laboriosam neque. In velit delectus et optio ut mollitia.", "Product 939", "S", "Footwear" },
                    { 972, new DateTime(2020, 8, 8, 10, 38, 58, 85, DateTimeKind.Local).AddTicks(702), "InStock", "Rem dolores et totam et laboriosam sit consequatur. Ut nisi ea id. Perferendis qui dicta aut a voluptatum rerum corporis natus. Impedit nobis eum voluptas et ut non ut enim. Perferendis sint libero veritatis et eos possimus et et.", "Product 972", "M", "Accessory" },
                    { 973, new DateTime(2020, 8, 8, 10, 38, 58, 85, DateTimeKind.Local).AddTicks(2460), "InStock", "Sunt quibusdam consequatur sint. Rerum sit quaerat suscipit. Voluptatem exercitationem blanditiis distinctio culpa. Repudiandae facilis eaque voluptatem tenetur.", "Product 973", "XS", "Accessory" },
                    { 974, new DateTime(2020, 8, 2, 10, 38, 58, 85, DateTimeKind.Local).AddTicks(4661), "OutStock", "Praesentium blanditiis commodi doloremque sint ipsam rem aspernatur. Quae iusto velit debitis. Quod voluptas sit suscipit illum molestiae. Nemo in facere saepe repellat.", "Product 974", "S", "Underwear" },
                    { 975, new DateTime(2020, 8, 22, 10, 38, 58, 85, DateTimeKind.Local).AddTicks(6560), "OutStock", "Adipisci animi eligendi minus ut praesentium porro vel omnis. Consequatur rerum ipsam facilis voluptatem molestiae. Saepe et sit velit in.", "Product 975", "S", "Footwear" },
                    { 976, new DateTime(2020, 8, 25, 10, 38, 58, 85, DateTimeKind.Local).AddTicks(8945), "InStock", "Aperiam aliquid quia cupiditate minus odio. Doloremque dolorem officiis debitis occaecati dolorem labore sed qui. Aut error quia ducimus explicabo. Odio et numquam quas error.", "Product 976", "M", "Outerwear" },
                    { 977, new DateTime(2020, 7, 10, 10, 38, 58, 86, DateTimeKind.Local).AddTicks(1319), "OutStock", "Fugiat dolor sed rerum quam consequatur aut atque. Et nam ut ullam et maxime officiis aut maxime. Architecto voluptas enim cumque commodi. Ut a laboriosam cupiditate.", "Product 977", "M", "Accessory" },
                    { 978, new DateTime(2020, 8, 24, 10, 38, 58, 86, DateTimeKind.Local).AddTicks(2716), "InStock", "Possimus facere laudantium rem. Et ipsum delectus est voluptatem doloremque. Aliquam est enim iste.", "Product 978", "M", "Underwear" },
                    { 979, new DateTime(2020, 9, 15, 10, 38, 58, 86, DateTimeKind.Local).AddTicks(4948), "OutStock", "Necessitatibus fuga est quia distinctio dolorem. Saepe ut sit totam sapiente aspernatur. Expedita alias vitae ab. Corporis sunt consectetur qui ea nostrum aut tempore.", "Product 979", "L", "Accessory" },
                    { 980, new DateTime(2020, 8, 9, 10, 38, 58, 86, DateTimeKind.Local).AddTicks(6671), "InStock", "Est veritatis adipisci veritatis aspernatur qui et placeat. Minus voluptas quae a aliquid qui. Deleniti porro reiciendis voluptatum.", "Product 980", "M", "Footwear" },
                    { 981, new DateTime(2020, 7, 4, 10, 38, 58, 86, DateTimeKind.Local).AddTicks(8115), "InStock", "Sint possimus in dolorum labore. Cum eligendi tempore dolore hic. Voluptatem quia officia voluptas.", "Product 981", "M", "Outerwear" },
                    { 982, new DateTime(2020, 8, 2, 10, 38, 58, 87, DateTimeKind.Local).AddTicks(763), "InStock", "Temporibus dolores iusto provident explicabo similique. Quis possimus commodi corporis eaque. Impedit placeat fugiat asperiores ratione quia sit commodi aut. Rerum et dolorem iste at et aliquid nobis error.", "Product 982", "XS", "Outerwear" },
                    { 983, new DateTime(2020, 7, 9, 10, 38, 58, 87, DateTimeKind.Local).AddTicks(2912), "InStock", "Eum quam odio magnam aut nemo reprehenderit nemo. Voluptas vero asperiores suscipit. Nesciunt voluptatum dolor aut. Velit quo unde et est porro aliquid.", "Product 983", "S", "Footwear" },
                    { 984, new DateTime(2020, 9, 12, 10, 38, 58, 87, DateTimeKind.Local).AddTicks(5652), "InStock", "Consequatur et et non est possimus non deserunt ut. Facilis ut sunt dolorem id assumenda aliquid blanditiis. Quis perspiciatis aliquam id sunt harum. Eveniet ex dicta earum autem repellat.", "Product 984", "S", "Outerwear" },
                    { 985, new DateTime(2020, 6, 27, 10, 38, 58, 87, DateTimeKind.Local).AddTicks(8652), "InStock", "Dolores excepturi dolore eum sapiente. Et ea non pariatur. Sed vero et recusandae consequatur. Reprehenderit possimus autem in odit tempore et optio et. Ipsam cum quis quo ipsa quidem provident et est.", "Product 985", "XS", "Accessory" },
                    { 986, new DateTime(2020, 6, 13, 10, 38, 58, 88, DateTimeKind.Local).AddTicks(1127), "InStock", "Earum pariatur et aut necessitatibus natus. Iure repellat ad deleniti et aperiam debitis repudiandae sint. Ad et nemo iure ratione eos. Quia eum doloribus nulla voluptatem debitis.", "Product 986", "S", "Outerwear" },
                    { 987, new DateTime(2020, 8, 19, 10, 38, 58, 88, DateTimeKind.Local).AddTicks(3252), "InStock", "Magni pariatur explicabo voluptas explicabo et a eveniet fuga. Cum dolores aut ad possimus animi cumque. Est et id laborum ad molestiae id.", "Product 987", "L", "Accessory" },
                    { 988, new DateTime(2020, 8, 13, 10, 38, 58, 88, DateTimeKind.Local).AddTicks(5529), "OutStock", "Omnis fuga aut enim sint. Et atque possimus autem praesentium. Ipsum id ipsa et et quod. Sit quae saepe voluptatem rem qui sit facilis.", "Product 988", "S", "Footwear" },
                    { 989, new DateTime(2020, 9, 3, 10, 38, 58, 88, DateTimeKind.Local).AddTicks(8755), "OutStock", "Quas non voluptas aut ducimus omnis delectus quis quod. Sit quod quo architecto ea sed modi assumenda. Praesentium nisi non nesciunt repellendus quod. Voluptatem dolore cum sunt debitis dolorem. Sit laboriosam voluptas excepturi optio atque aperiam.", "Product 989", "L", "Footwear" },
                    { 990, new DateTime(2020, 8, 30, 10, 38, 58, 89, DateTimeKind.Local).AddTicks(1657), "OutStock", "Rem facere nisi placeat sequi animi nesciunt nemo delectus. Et sunt at voluptatem eligendi. Ut corporis quia nam et quia aut. Exercitationem blanditiis laudantium qui necessitatibus eveniet. Quasi nemo repellat aut non.", "Product 990", "S", "Footwear" },
                    { 991, new DateTime(2020, 6, 19, 10, 38, 58, 89, DateTimeKind.Local).AddTicks(4444), "InStock", "Architecto pariatur quo sit ipsa maiores veniam. Sed quod quo est aut magnam sunt. Quia eaque suscipit sunt non non nisi aliquid. Maxime eveniet dolorem voluptatem. Est pariatur qui consequatur.", "Product 991", "S", "Outerwear" },
                    { 992, new DateTime(2020, 6, 24, 10, 38, 58, 89, DateTimeKind.Local).AddTicks(6948), "InStock", "Sit doloribus sit nam enim voluptatem asperiores libero. Et nostrum consectetur animi et laudantium commodi. Deserunt sapiente et rem vel ea quia rerum. Ipsam labore commodi cupiditate.", "Product 992", "L", "Underwear" },
                    { 993, new DateTime(2020, 8, 17, 10, 38, 58, 90, DateTimeKind.Local).AddTicks(24), "OutStock", "Quos sed esse et delectus tempore harum quo. Vitae tempore eveniet cupiditate quia error est non ut. Minus numquam vel laboriosam facilis vitae ut. Saepe quam magnam natus velit qui et et soluta.", "Product 993", "M", "Underwear" },
                    { 994, new DateTime(2020, 8, 6, 10, 38, 58, 90, DateTimeKind.Local).AddTicks(2069), "OutStock", "Dolore rerum dolores accusantium repellat. Labore non et dignissimos aliquid excepturi explicabo voluptatem iusto. Non facere dolor sapiente esse ut minus.", "Product 994", "M", "Accessory" },
                    { 995, new DateTime(2020, 6, 24, 10, 38, 58, 90, DateTimeKind.Local).AddTicks(4356), "InStock", "Eum harum voluptatibus accusantium. Nihil iusto sit tenetur laudantium accusantium perspiciatis deserunt. Illo omnis et dolorum aut voluptatem. Omnis repellat est libero velit recusandae.", "Product 995", "S", "Underwear" },
                    { 996, new DateTime(2020, 9, 3, 10, 38, 58, 90, DateTimeKind.Local).AddTicks(7240), "InStock", "Omnis ex aut provident ut. Quibusdam nostrum laudantium quia illo molestias iusto sed ut. Est eligendi sit repudiandae provident. Est consectetur nam ipsum dolorum cum aut. Omnis itaque ut voluptatem odio.", "Product 996", "M", "Accessory" },
                    { 997, new DateTime(2020, 8, 21, 10, 38, 58, 91, DateTimeKind.Local).AddTicks(41), "InStock", "Rerum quas ut laborum enim tenetur. Est numquam facere maiores modi ducimus illum ea qui. Corporis sint sequi nesciunt necessitatibus officia voluptatem. Qui rerum blanditiis odit facilis.", "Product 997", "L", "Outerwear" },
                    { 998, new DateTime(2020, 8, 23, 10, 38, 58, 91, DateTimeKind.Local).AddTicks(3031), "InStock", "Et molestias excepturi recusandae sunt molestiae. Ipsum iure consequuntur illo accusantium vero dolores harum qui. Ut harum quaerat nam enim neque id sint architecto. Consequatur amet fugit quis voluptatem exercitationem voluptas qui quia.", "Product 998", "L", "Accessory" },
                    { 971, new DateTime(2020, 7, 5, 10, 38, 58, 84, DateTimeKind.Local).AddTicks(7229), "InStock", "Neque non vero nisi sed. Voluptas debitis est in dolores aut laboriosam. Quisquam occaecati occaecati ut cum illum earum officiis. Voluptatem id ducimus nisi reprehenderit explicabo iusto non et. Esse est et voluptas non.", "Product 971", "M", "Outerwear" },
                    { 970, new DateTime(2020, 8, 11, 10, 38, 58, 84, DateTimeKind.Local).AddTicks(4188), "OutStock", "Consequatur in placeat voluptates voluptatem. Omnis voluptates deleniti nihil cumque ducimus eligendi corporis. Est dolorum eum esse omnis qui ut.", "Product 970", "L", "Outerwear" },
                    { 969, new DateTime(2020, 8, 4, 10, 38, 58, 84, DateTimeKind.Local).AddTicks(2252), "OutStock", "Hic ea voluptatem perspiciatis quae voluptatibus eveniet quo. Reprehenderit ea incidunt quo. Ipsa dolorum dolores ut recusandae ut.", "Product 969", "S", "Accessory" },
                    { 968, new DateTime(2020, 7, 26, 10, 38, 58, 84, DateTimeKind.Local).AddTicks(492), "InStock", "Quia numquam repellat ipsam cupiditate fugit deserunt suscipit. Earum quos sit maiores modi cupiditate ratione. Reprehenderit fugit eveniet magni eius consequuntur maxime rerum temporibus. Iusto pariatur numquam ut adipisci tempore id neque.", "Product 968", "S", "Accessory" },
                    { 940, new DateTime(2020, 8, 17, 10, 38, 58, 77, DateTimeKind.Local).AddTicks(2243), "OutStock", "Consequatur autem quis et. Ea velit delectus iusto quos tempora velit. Quaerat consectetur similique ducimus sint dolore dolorem repudiandae dolore.", "Product 940", "M", "Underwear" },
                    { 941, new DateTime(2020, 7, 21, 10, 38, 58, 77, DateTimeKind.Local).AddTicks(4991), "InStock", "Tempora aliquam quo veritatis. Labore ut reprehenderit sed tenetur aut ut debitis. Enim eum ut suscipit quia. Aut rerum nulla voluptatem hic sed vitae. Illo ea id ducimus et.", "Product 941", "M", "Accessory" },
                    { 942, new DateTime(2020, 7, 3, 10, 38, 58, 77, DateTimeKind.Local).AddTicks(8249), "InStock", "Dignissimos repellendus doloribus et fuga non aut qui deserunt. Neque eligendi deleniti placeat. Voluptatem aliquam vero voluptatem voluptatum quam voluptates. Possimus tempore ut nobis commodi labore id. Quis ipsa et qui laudantium earum et accusantium recusandae.", "Product 942", "M", "Footwear" },
                    { 943, new DateTime(2020, 7, 20, 10, 38, 58, 78, DateTimeKind.Local).AddTicks(565), "OutStock", "Eos ut voluptatem maxime. Ex quam quas sit voluptas aspernatur. Odio non minus doloribus dicta rerum sed. Amet quia dolorum optio a impedit et aut.", "Product 943", "L", "Outerwear" },
                    { 944, new DateTime(2020, 8, 10, 10, 38, 58, 78, DateTimeKind.Local).AddTicks(3075), "InStock", "Exercitationem est qui nesciunt blanditiis ex exercitationem rem qui. Omnis voluptatem optio eum ab occaecati consequatur. Accusantium sit aperiam doloribus nisi et. Sequi qui et deserunt voluptate.", "Product 944", "L", "Accessory" },
                    { 945, new DateTime(2020, 7, 26, 10, 38, 58, 78, DateTimeKind.Local).AddTicks(5738), "InStock", "Tempore id architecto expedita natus dolore et aut. Est non a beatae laudantium expedita velit aliquam aut. Minus maiores id molestiae consequatur. Voluptas quia rerum dolor sint ut fugit.", "Product 945", "L", "Underwear" },
                    { 946, new DateTime(2020, 9, 14, 10, 38, 58, 78, DateTimeKind.Local).AddTicks(8728), "OutStock", "Doloremque suscipit possimus sit beatae sed minima autem. Totam velit temporibus ullam consequatur distinctio autem ratione ut. Rerum dolore aut soluta sunt incidunt hic. Fugiat numquam incidunt odit dolorem sed voluptates et porro.", "Product 946", "M", "Accessory" },
                    { 947, new DateTime(2020, 7, 24, 10, 38, 58, 79, DateTimeKind.Local).AddTicks(1661), "OutStock", "Magni dignissimos aut et reprehenderit ut. Dignissimos et nisi aspernatur quae placeat. Ratione unde rerum molestiae dolorem vel ipsa. Voluptas voluptas assumenda in eos. Nisi cumque consequatur culpa laboriosam facilis consectetur excepturi.", "Product 947", "S", "Underwear" },
                    { 948, new DateTime(2020, 6, 15, 10, 38, 58, 79, DateTimeKind.Local).AddTicks(3672), "OutStock", "Necessitatibus qui quos consequuntur consequatur sint. Ea ipsa occaecati ad a animi. Quisquam commodi quis voluptatem quia id architecto voluptas dicta.", "Product 948", "S", "Accessory" },
                    { 949, new DateTime(2020, 8, 5, 10, 38, 58, 79, DateTimeKind.Local).AddTicks(6400), "InStock", "Commodi deleniti sapiente eligendi fuga temporibus reiciendis aut laboriosam. Eos earum debitis et eligendi eos aut minus. Praesentium omnis ex eius dicta quia. Suscipit nesciunt accusantium modi quas non tempora.", "Product 949", "L", "Outerwear" },
                    { 950, new DateTime(2020, 7, 21, 10, 38, 58, 79, DateTimeKind.Local).AddTicks(8857), "InStock", "Facere dolor corporis sint aspernatur alias voluptate. Cum commodi ut et accusamus dolores et qui. Qui eligendi voluptates voluptas minima impedit. Necessitatibus molestias ut et hic quia.", "Product 950", "M", "Outerwear" },
                    { 951, new DateTime(2020, 9, 18, 10, 38, 58, 80, DateTimeKind.Local).AddTicks(723), "InStock", "Non facilis quasi quia. Tenetur iusto ducimus sed voluptatibus ullam qui. Repellendus officiis velit quia. Voluptatem non aut et.", "Product 951", "M", "Underwear" },
                    { 952, new DateTime(2020, 7, 18, 10, 38, 58, 80, DateTimeKind.Local).AddTicks(3491), "OutStock", "Dignissimos culpa voluptatem dolores repellat non. Vitae non aut sequi aut. Qui sunt nam quod. Est praesentium enim est quasi aut sit veniam tenetur. Temporibus error nemo nihil amet quasi.", "Product 952", "XS", "Accessory" },
                    { 877, new DateTime(2020, 7, 28, 10, 38, 58, 62, DateTimeKind.Local).AddTicks(1434), "OutStock", "Natus sint quaerat incidunt. Odio qui cupiditate quo eligendi beatae eum. Reprehenderit molestiae maiores molestias et.", "Product 877", "S", "Outerwear" },
                    { 953, new DateTime(2020, 8, 29, 10, 38, 58, 80, DateTimeKind.Local).AddTicks(5903), "OutStock", "Quaerat inventore placeat ut et aliquam officiis. Veritatis deserunt esse magnam mollitia. Molestiae at nihil error animi. Doloribus ipsum et voluptatem. Quos et tempore quo officiis.", "Product 953", "M", "Outerwear" },
                    { 955, new DateTime(2020, 6, 18, 10, 38, 58, 81, DateTimeKind.Local).AddTicks(802), "InStock", "Qui quam ullam earum repellendus laboriosam. Quisquam illum enim qui aliquid. Placeat accusamus corrupti labore perspiciatis et. Ut deserunt culpa sint error.", "Product 955", "M", "Footwear" },
                    { 956, new DateTime(2020, 7, 10, 10, 38, 58, 81, DateTimeKind.Local).AddTicks(3472), "InStock", "Et eveniet at aut magni nihil. Sint quia illo et quia consequuntur earum. Molestiae praesentium necessitatibus eveniet necessitatibus molestiae laboriosam ea vel. Voluptatem ut aut iure sit et quod.", "Product 956", "XS", "Underwear" },
                    { 957, new DateTime(2020, 8, 1, 10, 38, 58, 81, DateTimeKind.Local).AddTicks(6463), "InStock", "Vel rem voluptas asperiores magni vero magnam reprehenderit commodi. Assumenda ea culpa impedit rerum ratione tempora distinctio sed. Sunt et id aut quod hic ea ex. Voluptatem voluptatem quia quisquam sed consectetur officiis.", "Product 957", "L", "Footwear" },
                    { 958, new DateTime(2020, 8, 17, 10, 38, 58, 81, DateTimeKind.Local).AddTicks(8651), "OutStock", "Ipsam autem est quae suscipit quia. Sapiente vero dolorum ducimus cupiditate ullam ab maxime quia. Et et maiores et consequatur dicta voluptatem mollitia consequuntur.", "Product 958", "M", "Underwear" },
                    { 959, new DateTime(2020, 8, 11, 10, 38, 58, 82, DateTimeKind.Local).AddTicks(665), "OutStock", "Numquam magni sit et sapiente illo ex ipsa ullam. Numquam maxime et assumenda eum et et et. Eligendi sit et vel cupiditate.", "Product 959", "S", "Accessory" },
                    { 960, new DateTime(2020, 6, 20, 10, 38, 58, 82, DateTimeKind.Local).AddTicks(3566), "InStock", "Aliquam qui repudiandae veniam est reprehenderit impedit. Aut ab et fugit voluptatem blanditiis facere. Voluptates vitae eligendi nihil animi. Repellendus quis error pariatur. Dolores dolor numquam quidem harum laborum provident in id.", "Product 960", "L", "Accessory" },
                    { 961, new DateTime(2020, 8, 4, 10, 38, 58, 82, DateTimeKind.Local).AddTicks(5812), "OutStock", "Veniam mollitia esse itaque aspernatur. Labore enim veniam consectetur libero. In veniam minus temporibus. Facilis aut doloribus iusto non omnis ut perspiciatis.", "Product 961", "S", "Footwear" },
                    { 962, new DateTime(2020, 8, 5, 10, 38, 58, 82, DateTimeKind.Local).AddTicks(7621), "OutStock", "A et repellendus neque molestiae qui nulla. Velit totam officia eos quia ipsum odio. Ipsam aperiam facilis eum maxime.", "Product 962", "L", "Underwear" },
                    { 963, new DateTime(2020, 8, 1, 10, 38, 58, 83, DateTimeKind.Local).AddTicks(172), "InStock", "Doloribus error perspiciatis sequi tenetur. Eius cupiditate ut fugit iusto sit ipsam quia. Sequi autem quia necessitatibus aliquam. Sunt placeat repudiandae impedit at rerum. Nihil impedit porro iure.", "Product 963", "XS", "Outerwear" },
                    { 964, new DateTime(2020, 8, 16, 10, 38, 58, 83, DateTimeKind.Local).AddTicks(2287), "OutStock", "Consequatur dignissimos suscipit dolorem adipisci quibusdam. Ullam sit occaecati veniam sint quasi non aut. Molestiae fuga modi omnis ipsa ut ut eum vel.", "Product 964", "XS", "Footwear" },
                    { 965, new DateTime(2020, 7, 14, 10, 38, 58, 83, DateTimeKind.Local).AddTicks(4636), "OutStock", "Consequatur beatae optio et accusamus corporis. Consectetur ipsa dolor soluta ut. In nostrum eum dolor odio occaecati voluptatum. Culpa voluptate qui maiores voluptatibus fuga.", "Product 965", "M", "Outerwear" },
                    { 966, new DateTime(2020, 7, 1, 10, 38, 58, 83, DateTimeKind.Local).AddTicks(6258), "InStock", "Doloremque et quia sint. Minus aperiam delectus deleniti necessitatibus dolorem vitae delectus ea. Voluptate culpa modi eveniet.", "Product 966", "M", "Accessory" },
                    { 967, new DateTime(2020, 8, 4, 10, 38, 58, 83, DateTimeKind.Local).AddTicks(7626), "InStock", "Ipsa facere sint voluptates. Nesciunt ut dignissimos molestiae suscipit. Nesciunt odit ipsa aliquid quos.", "Product 967", "S", "Footwear" },
                    { 954, new DateTime(2020, 6, 17, 10, 38, 58, 80, DateTimeKind.Local).AddTicks(8734), "InStock", "Commodi tempora in explicabo consequatur debitis et nulla voluptatem. Illum ad facilis quis est iste dignissimos qui. Velit fugiat corrupti nisi voluptas architecto in ut rerum. Nihil accusantium est et blanditiis.", "Product 954", "XS", "Outerwear" },
                    { 751, new DateTime(2020, 7, 26, 10, 38, 58, 31, DateTimeKind.Local).AddTicks(2776), "OutStock", "Rerum hic alias id doloribus deleniti nulla. Assumenda quo assumenda minima voluptas vel temporibus dolor non. Corrupti assumenda iusto et.", "Product 751", "L", "Accessory" },
                    { 876, new DateTime(2020, 9, 18, 10, 38, 58, 61, DateTimeKind.Local).AddTicks(9880), "InStock", "Eos autem enim minus repellat. Porro omnis similique alias laudantium. Nobis voluptatem eum harum sequi. Voluptates doloremque quaerat porro nobis. Nobis omnis dolorem cupiditate vitae sed est.", "Product 876", "XS", "Underwear" },
                    { 874, new DateTime(2020, 8, 27, 10, 38, 58, 61, DateTimeKind.Local).AddTicks(5398), "InStock", "Fugit nobis velit et provident saepe iste. Ratione occaecati ut distinctio. Delectus sit vel animi architecto architecto maxime. Non et eaque alias.", "Product 874", "M", "Outerwear" },
                    { 784, new DateTime(2020, 6, 18, 10, 38, 58, 40, DateTimeKind.Local).AddTicks(1248), "InStock", "Dolor quia voluptatum unde aut sunt qui tempore. Et nihil voluptas perspiciatis nam aliquam eius nihil. Omnis veritatis qui sed qui dolor optio labore.", "Product 784", "M", "Accessory" },
                    { 785, new DateTime(2020, 8, 29, 10, 38, 58, 40, DateTimeKind.Local).AddTicks(3927), "InStock", "Minus sint ut dolores sed consectetur. Fugit aut eos deserunt. Iure laudantium enim mollitia. Ipsum et quo alias voluptates facere. Possimus dolor perspiciatis ea autem reprehenderit enim voluptatem dolores.", "Product 785", "XS", "Accessory" },
                    { 786, new DateTime(2020, 8, 31, 10, 38, 58, 40, DateTimeKind.Local).AddTicks(6864), "InStock", "Adipisci voluptatem non numquam expedita in fuga autem. Quia est ipsam vero quibusdam. Cupiditate sint animi nihil voluptatum voluptas provident. Dolores a facilis dignissimos similique voluptates autem nihil. Ex quod delectus dicta.", "Product 786", "M", "Underwear" },
                    { 787, new DateTime(2020, 7, 23, 10, 38, 58, 40, DateTimeKind.Local).AddTicks(8285), "InStock", "Explicabo ea eveniet in. Tempore dolor enim velit dicta quas. Accusantium omnis eveniet qui.", "Product 787", "XS", "Footwear" },
                    { 788, new DateTime(2020, 9, 14, 10, 38, 58, 41, DateTimeKind.Local).AddTicks(1009), "InStock", "Et officiis sapiente distinctio similique labore omnis asperiores voluptatum. Voluptatibus et aut doloribus molestiae. Similique similique eius laborum laudantium dolorum et. Est fuga consequatur ad. Architecto laborum animi molestiae quis.", "Product 788", "M", "Footwear" },
                    { 789, new DateTime(2020, 8, 14, 10, 38, 58, 41, DateTimeKind.Local).AddTicks(2722), "InStock", "Aut voluptatem sequi aut. Omnis voluptatibus numquam cupiditate ab laudantium qui qui odio. Harum rerum et cupiditate dignissimos.", "Product 789", "XS", "Outerwear" },
                    { 790, new DateTime(2020, 8, 27, 10, 38, 58, 41, DateTimeKind.Local).AddTicks(4743), "InStock", "Neque delectus possimus officia sint expedita. Voluptatem quia magni facere ratione eos dicta. Qui nam nostrum quisquam voluptatem nostrum quo libero.", "Product 790", "L", "Accessory" },
                    { 791, new DateTime(2020, 8, 22, 10, 38, 58, 41, DateTimeKind.Local).AddTicks(6871), "InStock", "Excepturi quia quo architecto quia facere aut porro. Id non aut in distinctio nisi. Distinctio quia deleniti dignissimos expedita. Occaecati tempore neque et.", "Product 791", "L", "Outerwear" },
                    { 792, new DateTime(2020, 7, 4, 10, 38, 58, 41, DateTimeKind.Local).AddTicks(9656), "OutStock", "Esse quo sit quae nesciunt. Ea assumenda voluptatum qui quo ratione soluta. Explicabo dolor dolore laboriosam mollitia tenetur eligendi voluptas sed. Quia est unde qui. Sit inventore sit laudantium fugit.", "Product 792", "XS", "Underwear" },
                    { 793, new DateTime(2020, 7, 30, 10, 38, 58, 42, DateTimeKind.Local).AddTicks(2327), "OutStock", "Ea nobis in expedita voluptas nobis autem ipsa. Id fugit minus voluptas non. Sit corrupti sequi voluptas sit quas. Mollitia tempora magni accusantium accusantium. Explicabo sunt cupiditate quisquam numquam.", "Product 793", "XS", "Underwear" },
                    { 794, new DateTime(2020, 9, 7, 10, 38, 58, 42, DateTimeKind.Local).AddTicks(5541), "InStock", "Voluptatem veritatis minus cumque quia reprehenderit delectus voluptatem velit. Quos ex maxime velit. Fugiat vitae ipsam et explicabo mollitia temporibus cum. Inventore voluptate aliquid ipsam corrupti qui nisi placeat. Sed sint et error molestiae amet in.", "Product 794", "XS", "Footwear" },
                    { 795, new DateTime(2020, 8, 25, 10, 38, 58, 42, DateTimeKind.Local).AddTicks(7179), "OutStock", "Quia eius mollitia nesciunt. Quia et voluptatem saepe qui. Quo eum asperiores libero tempora blanditiis labore consequatur.", "Product 795", "S", "Footwear" },
                    { 796, new DateTime(2020, 9, 6, 10, 38, 58, 42, DateTimeKind.Local).AddTicks(8741), "InStock", "Non dolor ipsum autem molestias. Quidem praesentium odio commodi. Et qui ducimus voluptatibus sint esse pariatur.", "Product 796", "XS", "Outerwear" },
                    { 797, new DateTime(2020, 9, 11, 10, 38, 58, 43, DateTimeKind.Local).AddTicks(1313), "OutStock", "Expedita quia aspernatur assumenda id quia doloribus sint. Et sunt omnis consequatur ut est reprehenderit magni. Qui consequatur alias libero quibusdam dolor suscipit nihil. Ea hic facilis velit.", "Product 797", "M", "Outerwear" },
                    { 798, new DateTime(2020, 8, 23, 10, 38, 58, 43, DateTimeKind.Local).AddTicks(3704), "OutStock", "Voluptas aut praesentium dolores nam excepturi est laboriosam quam. Aut velit omnis consequatur earum qui. Impedit officiis dolorum voluptatem aut earum dignissimos. Consequatur repudiandae quo qui.", "Product 798", "S", "Footwear" },
                    { 799, new DateTime(2020, 6, 12, 10, 38, 58, 43, DateTimeKind.Local).AddTicks(6973), "InStock", "Debitis dolore possimus iste odit. Aut expedita eum laboriosam eum quas doloremque quo. Qui et nobis quae eos unde odit et dolor. Earum atque labore officia in corporis repellat voluptatem nihil. Eum voluptatem maxime itaque et.", "Product 799", "L", "Outerwear" },
                    { 800, new DateTime(2020, 9, 11, 10, 38, 58, 43, DateTimeKind.Local).AddTicks(9449), "OutStock", "Cum esse error totam praesentium necessitatibus doloremque. Repellendus enim sunt dignissimos placeat sequi a. Corrupti occaecati non natus. Totam qui quisquam quo ut consectetur magnam pariatur et.", "Product 800", "S", "Outerwear" },
                    { 801, new DateTime(2020, 8, 7, 10, 38, 58, 44, DateTimeKind.Local).AddTicks(2582), "OutStock", "Illo voluptatem consequatur qui consequatur. In ad dolore autem similique consequatur porro. Non aut enim magni dolores veniam adipisci id odit. Libero saepe voluptate eligendi commodi accusamus hic. Aut non corrupti sit molestias similique impedit.", "Product 801", "S", "Footwear" },
                    { 802, new DateTime(2020, 6, 13, 10, 38, 58, 44, DateTimeKind.Local).AddTicks(5259), "OutStock", "Dolor nobis debitis pariatur quis et molestiae aut. Non in at quos. Ut maxime quia libero voluptas quia at illum recusandae. Quisquam saepe sunt aliquam enim ut.", "Product 802", "M", "Accessory" },
                    { 803, new DateTime(2020, 7, 16, 10, 38, 58, 44, DateTimeKind.Local).AddTicks(7099), "InStock", "Sed vero illo dolor. Voluptatem soluta occaecati quaerat ratione. Illo tempore consectetur odio tenetur quos. Eos aut sapiente laudantium.", "Product 803", "L", "Accessory" },
                    { 804, new DateTime(2020, 8, 9, 10, 38, 58, 45, DateTimeKind.Local).AddTicks(359), "OutStock", "Itaque ad magnam qui est cum architecto maxime atque. Aut sit ullam est numquam dolorem. Nisi odio quia labore totam nihil aut aliquid. Dignissimos qui quia eos id laboriosam et repudiandae. Occaecati iste sunt voluptatem aut.", "Product 804", "S", "Underwear" },
                    { 805, new DateTime(2020, 8, 15, 10, 38, 58, 45, DateTimeKind.Local).AddTicks(2176), "OutStock", "Aut porro quas magni labore mollitia labore voluptates. Eum quia nihil odio hic veniam ut. Doloremque molestias et modi.", "Product 805", "L", "Outerwear" },
                    { 806, new DateTime(2020, 7, 25, 10, 38, 58, 45, DateTimeKind.Local).AddTicks(5258), "OutStock", "Molestiae qui quae hic nihil accusamus. Accusamus cum voluptatibus amet totam. Impedit sunt iusto est repudiandae magnam. Est eos magnam porro eum unde necessitatibus aut. Debitis cumque eveniet et doloremque eligendi dolores velit id.", "Product 806", "M", "Underwear" },
                    { 807, new DateTime(2020, 8, 13, 10, 38, 58, 45, DateTimeKind.Local).AddTicks(8479), "OutStock", "Rerum ipsa quia dolore et. Iusto sed veritatis quam quod. Nobis ad minima rerum illum ipsam ut est et. Non esse quos occaecati voluptatem quaerat impedit adipisci. Quis non sapiente dicta eveniet cumque autem ut placeat.", "Product 807", "M", "Footwear" },
                    { 808, new DateTime(2020, 7, 1, 10, 38, 58, 46, DateTimeKind.Local).AddTicks(1120), "OutStock", "Nihil explicabo repellendus suscipit unde in id modi. Temporibus vel cumque totam nesciunt. Explicabo repellendus aut dolorem facere. Ea quam voluptatem veritatis. Est accusamus quis dolore sit atque voluptas.", "Product 808", "S", "Outerwear" },
                    { 809, new DateTime(2020, 6, 14, 10, 38, 58, 46, DateTimeKind.Local).AddTicks(3334), "InStock", "Sit voluptatum laudantium quis. Ea eveniet minima atque quibusdam sit totam. Excepturi ratione laborum illo quo. Officia facilis ut ratione blanditiis non dolorem distinctio.", "Product 809", "XS", "Footwear" },
                    { 810, new DateTime(2020, 8, 9, 10, 38, 58, 46, DateTimeKind.Local).AddTicks(5209), "OutStock", "Eius voluptatem inventore vitae sint. Autem sint voluptates eius cupiditate totam ut. Molestiae aut illum asperiores sed dicta et.", "Product 810", "S", "Underwear" },
                    { 783, new DateTime(2020, 9, 12, 10, 38, 58, 39, DateTimeKind.Local).AddTicks(9046), "OutStock", "Itaque nulla ratione molestiae quis numquam expedita quaerat et. Tempore possimus quo laboriosam vitae itaque magni nisi. Dolorum laudantium nihil molestiae debitis unde. Dolore commodi tenetur et. Mollitia alias in sit dolores molestiae voluptas quae blanditiis.", "Product 783", "M", "Footwear" },
                    { 811, new DateTime(2020, 8, 20, 10, 38, 58, 46, DateTimeKind.Local).AddTicks(8237), "OutStock", "Placeat cum adipisci excepturi rerum omnis. Nesciunt et voluptatum iusto fugit. Qui voluptatem sint odit et commodi delectus et minima. Expedita animi hic libero quia quia repudiandae sequi et. Sapiente alias ad quos dolorem.", "Product 811", "XS", "Outerwear" },
                    { 782, new DateTime(2020, 7, 28, 10, 38, 58, 39, DateTimeKind.Local).AddTicks(5841), "OutStock", "Maiores aut quod et quis dolor voluptatem fugit assumenda. Quod id quia cumque aut quod. Adipisci eum commodi ex.", "Product 782", "S", "Accessory" },
                    { 780, new DateTime(2020, 9, 6, 10, 38, 58, 39, DateTimeKind.Local).AddTicks(2269), "InStock", "Ut voluptatibus repudiandae repellat error voluptas dignissimos at voluptatem. Est est voluptates aut consequatur nihil. Adipisci et inventore soluta.", "Product 780", "L", "Outerwear" },
                    { 753, new DateTime(2020, 8, 2, 10, 38, 58, 32, DateTimeKind.Local).AddTicks(425), "InStock", "Sit magnam sint culpa minima nisi nostrum eos doloribus. Molestiae accusantium repudiandae est. Aliquam iure sit voluptatem harum commodi quibusdam ducimus ea. Magnam dolore quibusdam sequi fugiat et ea. Tempora molestiae et quaerat maiores dolores ea.", "Product 753", "XS", "Accessory" },
                    { 754, new DateTime(2020, 9, 16, 10, 38, 58, 32, DateTimeKind.Local).AddTicks(2838), "OutStock", "Ducimus voluptas impedit sit reiciendis laboriosam. Dolorem voluptas aliquid et doloribus et modi facilis qui. Distinctio quis consequuntur enim a architecto rerum sequi.", "Product 754", "XS", "Accessory" },
                    { 755, new DateTime(2020, 7, 3, 10, 38, 58, 32, DateTimeKind.Local).AddTicks(5810), "OutStock", "Sed omnis sit beatae. Alias repellendus provident molestias. Non ea id eveniet doloremque. Enim magni minima qui recusandae quo illo corporis cupiditate. Similique vel minus sequi suscipit maxime.", "Product 755", "XS", "Footwear" },
                    { 756, new DateTime(2020, 6, 21, 10, 38, 58, 32, DateTimeKind.Local).AddTicks(7992), "InStock", "Recusandae aut vel ducimus. Non ut distinctio occaecati quo. Non eos consectetur voluptatibus. Sed nisi voluptates voluptatem harum magnam perspiciatis.", "Product 756", "S", "Underwear" },
                    { 757, new DateTime(2020, 9, 8, 10, 38, 58, 33, DateTimeKind.Local).AddTicks(246), "OutStock", "Distinctio eveniet sequi eum consequuntur quisquam a. Eligendi voluptas mollitia voluptas animi vero voluptatem aut. Neque esse qui exercitationem eius nihil.", "Product 757", "M", "Underwear" },
                    { 758, new DateTime(2020, 8, 13, 10, 38, 58, 33, DateTimeKind.Local).AddTicks(2312), "InStock", "Rem hic nesciunt doloribus. Est eum repellat itaque beatae dignissimos ipsum et quisquam. Fugiat veritatis earum odio corporis voluptatem.", "Product 758", "S", "Outerwear" },
                    { 759, new DateTime(2020, 8, 22, 10, 38, 58, 33, DateTimeKind.Local).AddTicks(5054), "OutStock", "Sint unde dolores accusamus odit ducimus sit. Ratione eveniet culpa ullam dolores dolores. Magnam a corporis nihil et ipsa et. Quia assumenda velit amet hic autem.", "Product 759", "M", "Underwear" },
                    { 760, new DateTime(2020, 7, 10, 10, 38, 58, 33, DateTimeKind.Local).AddTicks(8296), "OutStock", "Deserunt minus excepturi ipsum voluptatem est. Ratione autem et error qui commodi eius velit quas. Nostrum voluptas vel rerum eligendi possimus ducimus exercitationem. Assumenda maiores delectus totam fuga et ut tempora in.", "Product 760", "S", "Outerwear" },
                    { 761, new DateTime(2020, 6, 14, 10, 38, 58, 34, DateTimeKind.Local).AddTicks(1288), "InStock", "Est ut inventore facilis et unde. Sed voluptatem odio debitis quidem blanditiis quis. Non est aspernatur qui. Quia odit qui incidunt veritatis aperiam eum dolor. Quia vero dolorem blanditiis.", "Product 761", "L", "Underwear" },
                    { 762, new DateTime(2020, 7, 31, 10, 38, 58, 34, DateTimeKind.Local).AddTicks(3279), "OutStock", "Tempora delectus et odio rerum molestiae. Pariatur consequatur animi sed nihil veniam tempora molestiae. Aut facilis natus delectus.", "Product 762", "XS", "Outerwear" },
                    { 763, new DateTime(2020, 6, 17, 10, 38, 58, 34, DateTimeKind.Local).AddTicks(6227), "OutStock", "Repellat ipsa sunt velit consequatur. Rerum exercitationem eum et. Veniam facilis libero earum cupiditate dolor voluptas. Ut maiores reprehenderit cum doloremque fuga fugit. Id odit voluptas nostrum temporibus.", "Product 763", "S", "Footwear" },
                    { 764, new DateTime(2020, 9, 9, 10, 38, 58, 34, DateTimeKind.Local).AddTicks(8472), "OutStock", "Dolor sed dolorem qui vitae quis quia. Enim ut laudantium et itaque voluptatem sequi omnis aut. Est fuga in recusandae veniam.", "Product 764", "M", "Footwear" },
                    { 765, new DateTime(2020, 9, 18, 10, 38, 58, 35, DateTimeKind.Local).AddTicks(527), "InStock", "Quam aliquam voluptatum sapiente et sit delectus excepturi. Minus perferendis voluptatem omnis sit ex voluptates. Earum amet nulla voluptatum.", "Product 765", "XS", "Accessory" },
                    { 766, new DateTime(2020, 8, 13, 10, 38, 58, 35, DateTimeKind.Local).AddTicks(3702), "InStock", "Modi est officia tempore velit qui fuga. Rerum veritatis et unde in earum. In laboriosam facilis quod qui facere deserunt. Facere eos sed non facilis velit. Reprehenderit ipsa ut nostrum hic.", "Product 766", "L", "Accessory" },
                    { 767, new DateTime(2020, 7, 17, 10, 38, 58, 35, DateTimeKind.Local).AddTicks(7734), "OutStock", "Et sint nihil illum eveniet sequi ut aut. Magnam a dolorem vel praesentium id sunt explicabo fugiat. Harum minus esse beatae fugit exercitationem temporibus eligendi quia. Reprehenderit accusantium aliquam accusamus excepturi et aspernatur molestiae. Quasi totam velit doloribus non eaque.", "Product 767", "S", "Footwear" },
                    { 768, new DateTime(2020, 8, 6, 10, 38, 58, 36, DateTimeKind.Local).AddTicks(131), "OutStock", "Rerum consectetur aut qui earum et et minima. Nostrum placeat facilis veniam laboriosam eaque impedit. Cupiditate veniam aperiam voluptatum amet alias fugit expedita.", "Product 768", "S", "Accessory" },
                    { 769, new DateTime(2020, 8, 30, 10, 38, 58, 36, DateTimeKind.Local).AddTicks(3178), "InStock", "Consequuntur ex inventore tempora porro iure. Consequuntur vero eos numquam cupiditate et qui. Nisi aliquam nihil quia qui harum. Pariatur soluta ut voluptatem in. Tenetur et aut voluptatum ut.", "Product 769", "S", "Footwear" },
                    { 770, new DateTime(2020, 8, 12, 10, 38, 58, 36, DateTimeKind.Local).AddTicks(6034), "OutStock", "Natus id quia qui voluptatem dolorem. Possimus aut saepe expedita nihil sit. Qui perferendis quis dolores illum ea consequatur. Cumque distinctio praesentium consequatur. Consequuntur consequatur enim et.", "Product 770", "M", "Outerwear" },
                    { 771, new DateTime(2020, 7, 3, 10, 38, 58, 36, DateTimeKind.Local).AddTicks(9580), "InStock", "Ratione ad repellat corporis odio et hic ut alias. Debitis ipsam et laboriosam ut quam ut hic et. Id sit nulla error ut eveniet aliquid laborum reiciendis. Perferendis molestiae reiciendis asperiores ratione nulla assumenda omnis.", "Product 771", "S", "Underwear" },
                    { 772, new DateTime(2020, 6, 12, 10, 38, 58, 37, DateTimeKind.Local).AddTicks(3476), "InStock", "Non eaque et sed tempore dolorum est aut non. Minus dolorem libero ut voluptatum culpa. Quod perspiciatis incidunt ex et repellat est. Deserunt voluptate dolores recusandae aspernatur quas vel omnis. Voluptatem quam possimus et libero cupiditate minus asperiores dolore.", "Product 772", "XS", "Accessory" },
                    { 773, new DateTime(2020, 7, 2, 10, 38, 58, 37, DateTimeKind.Local).AddTicks(6304), "InStock", "Ullam et ut soluta quos unde expedita rerum aliquid. Ut molestiae harum eius. Porro impedit corrupti dicta ducimus perferendis vel. Sed odio numquam labore facilis quasi.", "Product 773", "S", "Underwear" },
                    { 774, new DateTime(2020, 7, 14, 10, 38, 58, 37, DateTimeKind.Local).AddTicks(8294), "OutStock", "Vero aut ut quis ut earum quis repudiandae. Qui dolores sit aspernatur similique. Nam recusandae quia repellat a quisquam doloremque aut.", "Product 774", "XS", "Underwear" },
                    { 775, new DateTime(2020, 9, 13, 10, 38, 58, 38, DateTimeKind.Local).AddTicks(284), "OutStock", "Deleniti adipisci non accusantium possimus. Dolor nisi sequi cumque quia omnis et. Aut dolorem est reprehenderit quia iusto et est reiciendis.", "Product 775", "XS", "Footwear" },
                    { 776, new DateTime(2020, 8, 13, 10, 38, 58, 38, DateTimeKind.Local).AddTicks(2430), "InStock", "Corrupti maiores dolorum facilis et est eum. Fugiat non nihil quibusdam aperiam est consectetur. Ad dicta ad dolor consequuntur est sunt sunt qui.", "Product 776", "L", "Footwear" },
                    { 777, new DateTime(2020, 7, 21, 10, 38, 58, 38, DateTimeKind.Local).AddTicks(5314), "InStock", "Nobis libero nisi dolor quia optio minima provident voluptatem. Vero commodi inventore numquam magnam dolores quis. Ea molestias rem reiciendis iusto debitis voluptatem ipsa. Hic quis non voluptate deleniti adipisci cupiditate enim.", "Product 777", "XS", "Accessory" },
                    { 778, new DateTime(2020, 6, 13, 10, 38, 58, 38, DateTimeKind.Local).AddTicks(8409), "OutStock", "Nesciunt occaecati ut aspernatur corrupti dolores saepe et. Recusandae voluptas qui reiciendis. Et non iusto officiis veniam. Exercitationem quos cupiditate totam et deleniti corrupti voluptatibus ratione. Dicta quia laborum excepturi consequuntur commodi enim facere.", "Product 778", "M", "Outerwear" },
                    { 779, new DateTime(2020, 9, 13, 10, 38, 58, 39, DateTimeKind.Local).AddTicks(460), "InStock", "Vel quisquam et nesciunt similique ut velit. Atque illum voluptatem in quod ex qui explicabo doloremque. Saepe mollitia et ipsam inventore quo.", "Product 779", "L", "Outerwear" },
                    { 781, new DateTime(2020, 7, 10, 10, 38, 58, 39, DateTimeKind.Local).AddTicks(3994), "InStock", "Sit aut dolorum distinctio harum vitae soluta et. Odit illum porro dolor. Numquam dolores sint reiciendis et id.", "Product 781", "M", "Outerwear" },
                    { 812, new DateTime(2020, 9, 7, 10, 38, 58, 47, DateTimeKind.Local).AddTicks(1297), "InStock", "Doloremque sapiente dolores in sunt aut ut laudantium autem. Nobis recusandae vel dolores ut delectus incidunt inventore. Aut cum est totam voluptatum quam laboriosam soluta in. Velit quibusdam quae consequatur alias nostrum laboriosam culpa.", "Product 812", "M", "Underwear" },
                    { 813, new DateTime(2020, 8, 19, 10, 38, 58, 47, DateTimeKind.Local).AddTicks(2919), "OutStock", "Explicabo ipsa omnis quis illum totam. Quasi suscipit ut quia. Voluptate explicabo sit aut velit et laboriosam.", "Product 813", "XS", "Outerwear" },
                    { 814, new DateTime(2020, 9, 4, 10, 38, 58, 47, DateTimeKind.Local).AddTicks(5164), "OutStock", "Aut repellendus sit in sunt delectus nostrum. Expedita tempore nobis deserunt. Molestias laborum dolor eum adipisci voluptas dolor numquam. Ea assumenda in quos facilis.", "Product 814", "XS", "Footwear" },
                    { 847, new DateTime(2020, 8, 3, 10, 38, 58, 54, DateTimeKind.Local).AddTicks(7902), "OutStock", "Asperiores quis ad eligendi qui. Ad quo aut reprehenderit dolor quia. Voluptatibus sequi sapiente ipsa odio rerum. Quod eum enim perferendis in aut. Nemo est sit veniam.", "Product 847", "L", "Accessory" },
                    { 848, new DateTime(2020, 8, 13, 10, 38, 58, 55, DateTimeKind.Local).AddTicks(434), "OutStock", "Eveniet facere fugit quia rerum. Molestias inventore quo architecto earum voluptas quo veritatis earum. Exercitationem voluptatem dolorem aut et eligendi vel. Illum ratione quo accusantium natus qui.", "Product 848", "L", "Underwear" },
                    { 849, new DateTime(2020, 9, 7, 10, 38, 58, 55, DateTimeKind.Local).AddTicks(3776), "OutStock", "Ut molestias cum aliquam iusto tempore sint repellat deserunt. Doloremque est amet voluptas earum consequatur architecto ab. At quam dolorum quia. Magnam eum sunt dolor quam inventore vitae dolor iusto. Excepturi debitis et id quasi est sequi.", "Product 849", "L", "Footwear" },
                    { 850, new DateTime(2020, 6, 30, 10, 38, 58, 55, DateTimeKind.Local).AddTicks(5801), "InStock", "Deleniti dignissimos praesentium soluta est quo voluptatem in. Laborum reprehenderit reiciendis nostrum voluptatum maxime nulla qui. Dignissimos laboriosam esse deserunt maiores.", "Product 850", "M", "Outerwear" },
                    { 851, new DateTime(2020, 7, 12, 10, 38, 58, 55, DateTimeKind.Local).AddTicks(8153), "OutStock", "Explicabo esse assumenda ex voluptatem iure. Quam deleniti consequatur minima reiciendis. Accusantium beatae adipisci est illo facilis error velit vel. Quidem aut sed recusandae hic.", "Product 851", "L", "Accessory" },
                    { 852, new DateTime(2020, 9, 13, 10, 38, 58, 56, DateTimeKind.Local).AddTicks(405), "OutStock", "Ut voluptatem et pariatur aliquid blanditiis. Ducimus nihil sit voluptatem quasi. Minima repudiandae mollitia dolor est consectetur. Accusamus possimus atque et quaerat architecto accusantium.", "Product 852", "M", "Footwear" },
                    { 853, new DateTime(2020, 8, 11, 10, 38, 58, 56, DateTimeKind.Local).AddTicks(2065), "InStock", "Maxime magnam quidem quo. Et omnis id voluptatum debitis dicta. Eligendi et voluptatum porro est voluptas reiciendis.", "Product 853", "XS", "Footwear" },
                    { 854, new DateTime(2020, 8, 31, 10, 38, 58, 56, DateTimeKind.Local).AddTicks(5709), "OutStock", "Enim molestiae est fugit voluptatem error odio aspernatur. Nisi qui vel eum qui qui nesciunt. Fuga quo architecto recusandae dolorum eligendi omnis similique non. Repellendus reprehenderit tempore culpa ut numquam facere. Non mollitia minima molestias minus perferendis quidem reiciendis optio.", "Product 854", "M", "Footwear" },
                    { 855, new DateTime(2020, 8, 20, 10, 38, 58, 56, DateTimeKind.Local).AddTicks(8104), "OutStock", "Nostrum eaque ut voluptates. Sed autem non ut. Nihil ad reiciendis sed esse nostrum nostrum distinctio consequatur. At quae fuga sunt inventore accusamus et ut eligendi.", "Product 855", "L", "Footwear" },
                    { 856, new DateTime(2020, 6, 28, 10, 38, 58, 57, DateTimeKind.Local).AddTicks(412), "OutStock", "Voluptatem alias aspernatur quibusdam et. Qui tempore qui vero eum quis. Placeat facere quidem aut deserunt sapiente natus aut vero. Eos qui est et culpa.", "Product 856", "L", "Underwear" },
                    { 857, new DateTime(2020, 6, 21, 10, 38, 58, 57, DateTimeKind.Local).AddTicks(2974), "OutStock", "Modi facilis et accusamus laudantium illum non quia. Aspernatur quo expedita nulla sapiente dolorem vitae blanditiis. Expedita natus voluptatem blanditiis aut ea. Sequi perferendis earum enim ut illum.", "Product 857", "S", "Accessory" },
                    { 858, new DateTime(2020, 7, 13, 10, 38, 58, 57, DateTimeKind.Local).AddTicks(6359), "InStock", "Quas perspiciatis accusantium sed excepturi voluptas. Natus rem eos quaerat architecto sequi ratione. Odit quia culpa est corrupti ullam repellat. Saepe recusandae minus nihil unde ut voluptas eveniet vel. Omnis dolor iusto aut voluptas in laboriosam aut.", "Product 858", "XS", "Accessory" },
                    { 859, new DateTime(2020, 8, 19, 10, 38, 58, 57, DateTimeKind.Local).AddTicks(8405), "InStock", "Non laborum doloremque autem molestias quia modi fugiat. Sint deserunt laborum ea quas. Cupiditate tempore eum nam adipisci sint est adipisci facere.", "Product 859", "M", "Underwear" },
                    { 860, new DateTime(2020, 8, 16, 10, 38, 58, 58, DateTimeKind.Local).AddTicks(129), "InStock", "Quod asperiores maiores dolores ut atque deserunt. Voluptas numquam rem enim voluptatem labore inventore. Alias commodi repellat et.", "Product 860", "XS", "Underwear" },
                    { 861, new DateTime(2020, 9, 10, 10, 38, 58, 58, DateTimeKind.Local).AddTicks(3052), "InStock", "Sed optio non ut dolorem. Explicabo corporis est soluta rerum. Quo modi natus nihil aut reprehenderit cupiditate est. Id inventore minima molestiae corrupti vero vero. Veritatis dicta non et in aut vel.", "Product 861", "M", "Underwear" },
                    { 862, new DateTime(2020, 7, 12, 10, 38, 58, 58, DateTimeKind.Local).AddTicks(5508), "OutStock", "Alias iusto corrupti placeat. Earum quidem eligendi tenetur quisquam exercitationem magnam nemo atque. Cum velit vel quis iste. Non et commodi sit temporibus mollitia nam et.", "Product 862", "L", "Underwear" },
                    { 863, new DateTime(2020, 8, 12, 10, 38, 58, 58, DateTimeKind.Local).AddTicks(8335), "InStock", "Perferendis quae cupiditate consequatur sunt. Sed aut eaque et vero et est omnis perferendis. Possimus explicabo explicabo iste harum eveniet animi ipsum. Sunt dignissimos perferendis pariatur non. Ut qui qui nam.", "Product 863", "S", "Underwear" },
                    { 864, new DateTime(2020, 9, 14, 10, 38, 58, 59, DateTimeKind.Local).AddTicks(150), "InStock", "Minima omnis ea eos error. Placeat omnis eveniet sit minus ut omnis omnis consequatur. Quo velit qui exercitationem id.", "Product 864", "S", "Footwear" },
                    { 865, new DateTime(2020, 9, 7, 10, 38, 58, 59, DateTimeKind.Local).AddTicks(2785), "InStock", "Saepe ipsa aliquid aliquam alias numquam. In ipsam modi magni quia et numquam. Neque id occaecati quaerat est. Pariatur placeat expedita quas. Enim dolores excepturi totam nesciunt et quia.", "Product 865", "L", "Footwear" },
                    { 866, new DateTime(2020, 6, 15, 10, 38, 58, 59, DateTimeKind.Local).AddTicks(5038), "OutStock", "Consequatur numquam et ut. Eum qui expedita sunt laborum ut. Maiores est et voluptas non nulla et facilis. Iure laboriosam quo voluptates dolor cupiditate.", "Product 866", "S", "Footwear" },
                    { 867, new DateTime(2020, 9, 6, 10, 38, 58, 59, DateTimeKind.Local).AddTicks(8285), "OutStock", "Reprehenderit ut et quidem. Voluptates odit eum omnis ab ratione ratione quisquam consequuntur. Officia non rem incidunt vitae quia delectus. Aut voluptates consequuntur labore alias dolore tempore. Ipsam nobis velit minus doloremque dolor dolores dolore repellendus.", "Product 867", "L", "Accessory" },
                    { 868, new DateTime(2020, 8, 17, 10, 38, 58, 60, DateTimeKind.Local).AddTicks(249), "InStock", "Fugiat ipsam voluptatem corrupti debitis repellat voluptatem. Distinctio aperiam similique nostrum. Id quia minus delectus. Aliquid quia repellat voluptates qui porro.", "Product 868", "XS", "Outerwear" },
                    { 869, new DateTime(2020, 8, 5, 10, 38, 58, 60, DateTimeKind.Local).AddTicks(2857), "OutStock", "Dicta similique facilis quia blanditiis nisi et. Odit et est voluptatem molestiae porro aliquam. Saepe magnam et et. Officia aut veniam cum quia autem adipisci. Quas ab et eos.", "Product 869", "XS", "Outerwear" },
                    { 870, new DateTime(2020, 8, 22, 10, 38, 58, 60, DateTimeKind.Local).AddTicks(5818), "InStock", "Et voluptas nostrum vel aut quia ex ut. Blanditiis dolorum facere officiis et fuga voluptatibus ipsam ut. Voluptas qui similique dignissimos rerum rerum et. Et autem iure iure qui enim amet tenetur aliquam.", "Product 870", "XS", "Underwear" },
                    { 871, new DateTime(2020, 7, 26, 10, 38, 58, 60, DateTimeKind.Local).AddTicks(7829), "OutStock", "Sed quis nam deserunt qui qui possimus ipsum. Iste autem ut quo excepturi qui quo asperiores laborum. Iste officia ad dolorem.", "Product 871", "XS", "Accessory" },
                    { 872, new DateTime(2020, 7, 3, 10, 38, 58, 61, DateTimeKind.Local).AddTicks(43), "OutStock", "Labore at et delectus et quibusdam est amet facilis. Pariatur eum quis saepe ab voluptatem perspiciatis. Non esse quaerat esse nulla voluptate sunt perferendis.", "Product 872", "L", "Footwear" },
                    { 873, new DateTime(2020, 8, 7, 10, 38, 58, 61, DateTimeKind.Local).AddTicks(3288), "InStock", "Dolores vel facere commodi et quae. Quia molestiae rem ut tenetur. Perspiciatis rerum id neque ullam et et atque facere. Beatae veniam sed mollitia aut dolor illum quis autem. Vel quae voluptas qui soluta omnis ut.", "Product 873", "L", "Underwear" },
                    { 846, new DateTime(2020, 9, 3, 10, 38, 58, 54, DateTimeKind.Local).AddTicks(5390), "InStock", "Rerum tempore deserunt eum laudantium enim debitis ad pariatur. Enim rerum id est labore. Cumque incidunt dolorem dolorem nostrum perferendis molestiae neque sit. Vero eum omnis culpa architecto et iusto cupiditate maxime.", "Product 846", "XS", "Accessory" },
                    { 845, new DateTime(2020, 6, 19, 10, 38, 58, 54, DateTimeKind.Local).AddTicks(2404), "OutStock", "Nemo quis non ut laboriosam inventore numquam eveniet. Unde perferendis nihil suscipit sunt culpa ipsam. Soluta eos assumenda commodi culpa. Debitis officia quia odio corporis corrupti ut omnis.", "Product 845", "L", "Underwear" },
                    { 844, new DateTime(2020, 6, 17, 10, 38, 58, 53, DateTimeKind.Local).AddTicks(9870), "OutStock", "Omnis ut modi corrupti dignissimos. Dolor nobis aut aliquam nesciunt qui officia. Expedita reprehenderit autem sunt sequi.", "Product 844", "S", "Footwear" },
                    { 843, new DateTime(2020, 9, 12, 10, 38, 58, 53, DateTimeKind.Local).AddTicks(8207), "OutStock", "Facere quasi tenetur sed. Molestias reprehenderit non velit at recusandae possimus consequatur aspernatur. Dolore inventore ut hic aut quam.", "Product 843", "S", "Underwear" },
                    { 815, new DateTime(2020, 6, 12, 10, 38, 58, 47, DateTimeKind.Local).AddTicks(8125), "OutStock", "Aperiam quibusdam officiis placeat saepe enim inventore. Et reiciendis molestiae doloremque qui laboriosam voluptatum nobis voluptatem. Animi et perspiciatis dicta dignissimos repellat amet quasi. Veniam et voluptatibus ut velit aut et eum quas.", "Product 815", "XS", "Underwear" },
                    { 816, new DateTime(2020, 8, 6, 10, 38, 58, 48, DateTimeKind.Local).AddTicks(663), "OutStock", "Iure adipisci iste ex et voluptatem in a. Eaque delectus adipisci ducimus dicta quis provident porro. Aliquid distinctio provident quos distinctio sunt voluptatem quo. Nisi ratione dolore rem.", "Product 816", "M", "Accessory" },
                    { 817, new DateTime(2020, 8, 6, 10, 38, 58, 48, DateTimeKind.Local).AddTicks(2251), "OutStock", "Magni mollitia atque nulla exercitationem non iste. Eum nostrum illo voluptatum officia. Accusamus nulla fugiat corrupti.", "Product 817", "L", "Underwear" },
                    { 818, new DateTime(2020, 9, 17, 10, 38, 58, 48, DateTimeKind.Local).AddTicks(4215), "OutStock", "Nostrum odio doloremque ipsa pariatur et. Libero magnam omnis reiciendis repellendus voluptatem quis. Corrupti aut magni aut nihil iste saepe et.", "Product 818", "S", "Outerwear" },
                    { 819, new DateTime(2020, 6, 23, 10, 38, 58, 48, DateTimeKind.Local).AddTicks(6484), "OutStock", "Sequi neque a et magnam. Illum est rerum quis ut molestiae est perferendis autem. Praesentium pariatur magni et perferendis sit. Ipsum omnis dicta eum quia.", "Product 819", "S", "Underwear" },
                    { 820, new DateTime(2020, 6, 30, 10, 38, 58, 48, DateTimeKind.Local).AddTicks(9512), "OutStock", "Consequatur excepturi mollitia totam aut aliquid id et inventore. Hic voluptate tempora fuga excepturi porro enim doloribus. Sapiente temporibus unde culpa voluptatem. Debitis velit occaecati ipsam. Ipsa aspernatur adipisci sed quae sit architecto consequatur.", "Product 820", "XS", "Footwear" },
                    { 821, new DateTime(2020, 7, 3, 10, 38, 58, 49, DateTimeKind.Local).AddTicks(1055), "InStock", "Et nihil dolorum delectus. Saepe repudiandae eos totam enim illo distinctio ducimus. Modi ut quam quasi.", "Product 821", "S", "Outerwear" },
                    { 822, new DateTime(2020, 7, 21, 10, 38, 58, 49, DateTimeKind.Local).AddTicks(2832), "OutStock", "Velit et possimus error nostrum sapiente. Est vitae quis natus non quos ex. Debitis quibusdam voluptatum et quas eos.", "Product 822", "XS", "Underwear" },
                    { 823, new DateTime(2020, 9, 11, 10, 38, 58, 49, DateTimeKind.Local).AddTicks(4560), "OutStock", "Quaerat eius delectus accusantium error et. Quis vitae consequatur fuga deleniti qui velit asperiores. Dolores iure odio qui.", "Product 823", "S", "Outerwear" },
                    { 824, new DateTime(2020, 6, 14, 10, 38, 58, 49, DateTimeKind.Local).AddTicks(7106), "OutStock", "Quod qui vero excepturi sint eum eum laudantium nulla. Provident id facilis neque cupiditate et sint. Modi quas ullam enim sunt soluta. Ab qui facilis provident est est.", "Product 824", "XS", "Accessory" },
                    { 825, new DateTime(2020, 9, 8, 10, 38, 58, 49, DateTimeKind.Local).AddTicks(8760), "InStock", "Quo et omnis et eum cumque et. Ut incidunt a quisquam cum laborum. Sunt distinctio blanditiis sed.", "Product 825", "L", "Underwear" },
                    { 826, new DateTime(2020, 9, 18, 10, 38, 58, 50, DateTimeKind.Local).AddTicks(827), "OutStock", "Qui voluptate eligendi fuga. Nihil sed magnam eos officiis. Eos temporibus ab consequatur. Et quia rem non tenetur dolor aliquam doloribus et.", "Product 826", "XS", "Accessory" },
                    { 827, new DateTime(2020, 8, 2, 10, 38, 58, 50, DateTimeKind.Local).AddTicks(2222), "InStock", "Enim doloremque adipisci qui illo voluptatem. Quae consequatur nihil et. Illo numquam sed fugit.", "Product 827", "M", "Underwear" },
                    { 875, new DateTime(2020, 6, 13, 10, 38, 58, 61, DateTimeKind.Local).AddTicks(7412), "OutStock", "Impedit aut quidem et ipsum ea nihil. Mollitia provident iusto quod explicabo optio rerum doloremque. Sunt sed odio enim eius quia ratione.", "Product 875", "M", "Footwear" },
                    { 828, new DateTime(2020, 7, 13, 10, 38, 58, 50, DateTimeKind.Local).AddTicks(4230), "InStock", "Ut modi esse est illo. Occaecati assumenda minima et consequatur exercitationem id. Ea veniam eveniet et. Rerum sit dicta rerum sit.", "Product 828", "XS", "Underwear" },
                    { 830, new DateTime(2020, 6, 19, 10, 38, 58, 50, DateTimeKind.Local).AddTicks(9914), "OutStock", "Ea dolor veniam et laborum maxime. Dolor vero voluptate placeat voluptatem voluptatibus. In beatae et maiores atque corrupti corporis enim expedita.", "Product 830", "S", "Underwear" },
                    { 831, new DateTime(2020, 8, 20, 10, 38, 58, 51, DateTimeKind.Local).AddTicks(3093), "OutStock", "Nobis ab voluptates accusamus quasi ab repudiandae ut. Omnis ipsam eius nulla aut suscipit dolores qui omnis. Laboriosam architecto aut commodi ad molestiae quia. Sed aut necessitatibus magni. Totam reiciendis et et omnis enim laudantium ipsum.", "Product 831", "M", "Accessory" },
                    { 832, new DateTime(2020, 8, 17, 10, 38, 58, 51, DateTimeKind.Local).AddTicks(6139), "OutStock", "Mollitia est dolore aperiam facere. Consectetur vel dignissimos dolores commodi. Soluta temporibus maxime earum amet deserunt enim ut reiciendis. Impedit rerum nesciunt ad neque commodi. Delectus enim sed accusantium neque debitis id dolorum.", "Product 832", "L", "Footwear" },
                    { 833, new DateTime(2020, 6, 13, 10, 38, 58, 51, DateTimeKind.Local).AddTicks(7719), "InStock", "Ut quis et similique. Illo soluta aut omnis blanditiis. Labore pariatur voluptas corporis doloribus quo repellat.", "Product 833", "M", "Accessory" },
                    { 834, new DateTime(2020, 6, 14, 10, 38, 58, 51, DateTimeKind.Local).AddTicks(9871), "InStock", "Quas qui quo provident explicabo. Rem vel eos sed non ipsa. Sed accusantium aliquam et error rerum repudiandae. Veritatis excepturi aut porro libero.", "Product 834", "S", "Footwear" },
                    { 835, new DateTime(2020, 7, 12, 10, 38, 58, 52, DateTimeKind.Local).AddTicks(2557), "OutStock", "Qui voluptatem inventore laboriosam non ex consequuntur. Eligendi reiciendis ut debitis. Nemo consequuntur et nesciunt qui autem cupiditate earum. Sit nihil quia facilis sapiente repellendus. Accusamus asperiores aperiam voluptate.", "Product 835", "M", "Underwear" },
                    { 836, new DateTime(2020, 7, 9, 10, 38, 58, 52, DateTimeKind.Local).AddTicks(4462), "InStock", "Dolor nulla et laudantium sunt. In eos libero mollitia eos natus necessitatibus perspiciatis. Vitae aliquam aliquid ut quasi aliquam repellendus.", "Product 836", "XS", "Underwear" },
                    { 837, new DateTime(2020, 6, 23, 10, 38, 58, 52, DateTimeKind.Local).AddTicks(7126), "OutStock", "Voluptate sequi accusantium iste vitae. Omnis non unde sint aut. Voluptatum illum et vel quia consequatur et molestiae aut. Ipsum eum perferendis quis. Adipisci sed qui ut at minima.", "Product 837", "M", "Accessory" },
                    { 838, new DateTime(2020, 7, 16, 10, 38, 58, 52, DateTimeKind.Local).AddTicks(9613), "OutStock", "Necessitatibus sint sit magni officia possimus soluta voluptate. Quaerat nobis neque blanditiis nobis error cumque reprehenderit minima. Reiciendis ad autem et hic. Doloribus dolore est nostrum dicta.", "Product 838", "XS", "Outerwear" },
                    { 839, new DateTime(2020, 7, 23, 10, 38, 58, 53, DateTimeKind.Local).AddTicks(1369), "OutStock", "Dolor omnis veritatis dolore iusto labore facilis. Enim inventore consequatur quia et. Natus qui accusantium natus modi quos.", "Product 839", "S", "Underwear" },
                    { 840, new DateTime(2020, 7, 16, 10, 38, 58, 53, DateTimeKind.Local).AddTicks(3090), "OutStock", "Dolorum odio sed dolore dolorem atque eos. Et numquam eos aut exercitationem. Rerum ea reprehenderit eaque vel natus.", "Product 840", "S", "Accessory" },
                    { 841, new DateTime(2020, 6, 29, 10, 38, 58, 53, DateTimeKind.Local).AddTicks(4630), "OutStock", "Quidem voluptatem sint est est. Blanditiis doloribus voluptatibus non nobis. Illo quidem facilis molestiae assumenda.", "Product 841", "XS", "Outerwear" },
                    { 842, new DateTime(2020, 7, 4, 10, 38, 58, 53, DateTimeKind.Local).AddTicks(6373), "OutStock", "Similique molestiae saepe et occaecati iure qui id. Nihil quod incidunt occaecati minima. Exercitationem ut minima deserunt quidem.", "Product 842", "L", "Underwear" },
                    { 829, new DateTime(2020, 8, 7, 10, 38, 58, 50, DateTimeKind.Local).AddTicks(7945), "OutStock", "Nobis nemo eligendi ut maiores et libero iure. Consequatur et facilis nulla et hic facilis minus aut. Facere quia est tempora omnis sed omnis sed laboriosam. At at placeat explicabo voluptas nihil officiis. Qui in suscipit est quo repudiandae blanditiis autem facere.", "Product 829", "L", "Underwear" },
                    { 501, new DateTime(2020, 7, 2, 10, 38, 57, 933, DateTimeKind.Local).AddTicks(6077), "OutStock", "Id eligendi soluta perspiciatis architecto dolorem. Rerum eius voluptatibus nisi quia perferendis dolor asperiores. Molestiae veniam nesciunt commodi deserunt pariatur. Nostrum laudantium natus reiciendis quasi nihil aperiam ex. Unde sit qui deserunt consectetur quia tenetur qui.", "Product 501", "XS", "Accessory" },
                    { 500, new DateTime(2020, 9, 7, 10, 38, 57, 933, DateTimeKind.Local).AddTicks(2084), "OutStock", "Provident sint nam cum tempore debitis sint qui odio. Possimus quia tenetur quae quia. Quia ea veniam reprehenderit provident quaerat facere earum. Ex et rerum praesentium minus ut eveniet et voluptas.", "Product 500", "XS", "Footwear" },
                    { 499, new DateTime(2020, 7, 13, 10, 38, 57, 932, DateTimeKind.Local).AddTicks(8630), "InStock", "Numquam corporis et tempora id. Doloremque aliquam quas labore. Dolores voluptas doloremque doloribus ut molestiae.", "Product 499", "S", "Accessory" },
                    { 158, new DateTime(2020, 7, 12, 10, 38, 57, 682, DateTimeKind.Local).AddTicks(891), "InStock", "Voluptas nobis voluptas incidunt ad ut itaque. Ratione autem nostrum explicabo quis. Officia adipisci veritatis rerum dolor neque facere. Et autem et esse autem eos quis nemo consequuntur. Ut voluptatem numquam odit voluptates ut quas.", "Product 158", "M", "Accessory" },
                    { 159, new DateTime(2020, 7, 15, 10, 38, 57, 682, DateTimeKind.Local).AddTicks(7156), "InStock", "Et veniam quod maiores quis aut. Minima at in ut vel dolor. Illo et ut velit placeat doloremque eaque qui facilis. Corrupti veritatis quasi non eaque aut saepe sed. Perspiciatis sequi neque fugit molestiae neque reprehenderit veritatis sapiente.", "Product 159", "S", "Accessory" },
                    { 160, new DateTime(2020, 6, 19, 10, 38, 57, 683, DateTimeKind.Local).AddTicks(1501), "InStock", "Qui illum eos asperiores. Qui ipsa id placeat sed asperiores. Illum autem hic minus voluptatem earum ut voluptatem. Consequatur deserunt optio dolore consequatur ea atque aut.", "Product 160", "L", "Footwear" },
                    { 161, new DateTime(2020, 7, 18, 10, 38, 57, 683, DateTimeKind.Local).AddTicks(6690), "InStock", "Et a inventore officiis odio dolorum et non. Eum asperiores minima qui ut nam. Illo mollitia ipsum ipsa exercitationem accusantium ratione officia. Accusantium molestiae occaecati qui nisi explicabo adipisci tempora qui.", "Product 161", "XS", "Outerwear" },
                    { 162, new DateTime(2020, 9, 7, 10, 38, 57, 684, DateTimeKind.Local).AddTicks(1045), "OutStock", "Excepturi quo corrupti tempore et est accusantium. Consectetur iusto laborum deleniti. Nesciunt non voluptatibus totam sunt sit beatae. Animi et minima voluptatem sunt dolore sit consequatur.", "Product 162", "XS", "Outerwear" },
                    { 163, new DateTime(2020, 7, 24, 10, 38, 57, 684, DateTimeKind.Local).AddTicks(3410), "InStock", "Cum aspernatur rerum autem omnis. Libero totam nobis expedita. Sint beatae omnis commodi.", "Product 163", "XS", "Underwear" },
                    { 164, new DateTime(2020, 6, 14, 10, 38, 57, 684, DateTimeKind.Local).AddTicks(7329), "OutStock", "Deleniti dolor recusandae ex explicabo maxime totam. Nesciunt laudantium inventore soluta quae ab aliquid ab. Velit nihil sapiente blanditiis ea voluptatem ut provident.", "Product 164", "L", "Accessory" },
                    { 165, new DateTime(2020, 7, 10, 10, 38, 57, 685, DateTimeKind.Local).AddTicks(2878), "OutStock", "Totam magni incidunt fugit voluptatem. Temporibus dolorem natus et quaerat molestiae illo error. Id nobis eum consequatur et dolor dolorem aperiam. Enim dolore rerum sapiente inventore doloremque debitis maxime blanditiis. Est quis sunt ea.", "Product 165", "XS", "Footwear" },
                    { 166, new DateTime(2020, 8, 5, 10, 38, 57, 685, DateTimeKind.Local).AddTicks(8381), "OutStock", "Repellat id libero recusandae ea ea laudantium. Enim blanditiis sunt et expedita. Quis accusamus quae sunt eum suscipit voluptas molestias. Est aspernatur magnam dolor consequatur aliquid autem. Aliquid id ad repudiandae quae ratione.", "Product 166", "XS", "Outerwear" },
                    { 167, new DateTime(2020, 8, 28, 10, 38, 57, 686, DateTimeKind.Local).AddTicks(2736), "OutStock", "Est quia ipsam ducimus omnis est ut. Voluptatibus sint dolorum alias omnis consequatur non. Dolor odio in et pariatur. Ut est quae aut asperiores quaerat omnis.", "Product 167", "S", "Accessory" },
                    { 168, new DateTime(2020, 7, 19, 10, 38, 57, 686, DateTimeKind.Local).AddTicks(5683), "OutStock", "Qui sint est quasi. Eaque sunt quas numquam et excepturi laboriosam. Eius earum et perspiciatis deserunt eos.", "Product 168", "XS", "Outerwear" },
                    { 169, new DateTime(2020, 6, 12, 10, 38, 57, 686, DateTimeKind.Local).AddTicks(9373), "OutStock", "Quia vel ut id. Alias debitis eius sit beatae ut. Rerum ea distinctio voluptas eius dicta. Modi qui consectetur est incidunt.", "Product 169", "S", "Accessory" },
                    { 170, new DateTime(2020, 7, 11, 10, 38, 57, 687, DateTimeKind.Local).AddTicks(2040), "OutStock", "Eius sunt qui repudiandae. Non sunt neque nihil odio ducimus qui dolorem. Nesciunt aspernatur laudantium consequuntur temporibus.", "Product 170", "S", "Accessory" },
                    { 171, new DateTime(2020, 9, 16, 10, 38, 57, 687, DateTimeKind.Local).AddTicks(5066), "OutStock", "Dolorem et est autem sint. Autem quia quia assumenda recusandae ipsum qui. Eaque et explicabo aut repudiandae qui saepe officia.", "Product 171", "M", "Underwear" },
                    { 172, new DateTime(2020, 8, 20, 10, 38, 57, 687, DateTimeKind.Local).AddTicks(8834), "InStock", "Natus ut aut libero illo accusamus minima quia incidunt. Id expedita autem voluptatibus perspiciatis et iusto libero consequatur. Cumque eum quidem eaque dolorem delectus impedit.", "Product 172", "M", "Underwear" },
                    { 173, new DateTime(2020, 9, 13, 10, 38, 57, 688, DateTimeKind.Local).AddTicks(1573), "OutStock", "Accusamus placeat voluptas autem ut. Voluptatibus itaque facilis numquam. Vel sit corrupti omnis ut laudantium ipsum sed.", "Product 173", "L", "Accessory" },
                    { 174, new DateTime(2020, 8, 11, 10, 38, 57, 688, DateTimeKind.Local).AddTicks(4261), "OutStock", "Quibusdam qui voluptatem velit. Alias sed quis necessitatibus accusantium magni alias. Cum autem itaque vel et eligendi.", "Product 174", "S", "Outerwear" },
                    { 175, new DateTime(2020, 7, 3, 10, 38, 57, 688, DateTimeKind.Local).AddTicks(9241), "InStock", "In incidunt veniam assumenda quam voluptas. Nulla ut optio non tempora consequatur enim et. Consequatur animi maiores quisquam numquam non. Autem dicta modi reiciendis velit voluptates. Nihil occaecati pariatur saepe excepturi laboriosam dolores illo.", "Product 175", "M", "Underwear" },
                    { 176, new DateTime(2020, 6, 28, 10, 38, 57, 689, DateTimeKind.Local).AddTicks(3230), "OutStock", "Omnis nesciunt dolor excepturi. Blanditiis quibusdam omnis minus saepe. Autem illo error nostrum aut debitis. Adipisci porro earum excepturi excepturi tenetur. Quasi sed aperiam non praesentium.", "Product 176", "L", "Footwear" },
                    { 177, new DateTime(2020, 6, 13, 10, 38, 57, 689, DateTimeKind.Local).AddTicks(8774), "OutStock", "Quos quis ea est hic recusandae tenetur in. Molestias voluptatibus consequatur ut consequuntur commodi in ea quos. Consequuntur labore quod quas sapiente. Nisi possimus repudiandae similique aut quo natus ipsa. Pariatur doloribus voluptas quibusdam consequatur sit impedit autem.", "Product 177", "S", "Outerwear" },
                    { 178, new DateTime(2020, 6, 25, 10, 38, 57, 690, DateTimeKind.Local).AddTicks(2169), "InStock", "Quidem veritatis vitae accusamus adipisci. Sunt reiciendis fugit id voluptatem. Nostrum at sint ut vel. Dolorem sint numquam qui et deserunt veritatis.", "Product 178", "M", "Accessory" },
                    { 179, new DateTime(2020, 8, 4, 10, 38, 57, 690, DateTimeKind.Local).AddTicks(5858), "OutStock", "Ea est aut est. Aperiam deserunt eveniet quam dolorem. Voluptas quisquam corporis quasi distinctio voluptas rerum voluptatem repellendus. Corrupti molestiae vel modi optio quidem minus.", "Product 179", "S", "Accessory" },
                    { 180, new DateTime(2020, 8, 26, 10, 38, 57, 690, DateTimeKind.Local).AddTicks(8585), "InStock", "Quibusdam doloribus eligendi suscipit maiores. Beatae qui aut aut repellat quis ratione. Sit ullam unde enim eos.", "Product 180", "L", "Footwear" },
                    { 181, new DateTime(2020, 7, 3, 10, 38, 57, 691, DateTimeKind.Local).AddTicks(2340), "OutStock", "Nulla sit placeat deserunt. Voluptas voluptates sit libero dolorum. Ratione vel quam dolor aperiam modi ipsum. Sunt eius explicabo eos. Omnis necessitatibus aliquam suscipit delectus.", "Product 181", "S", "Underwear" },
                    { 182, new DateTime(2020, 7, 10, 10, 38, 57, 691, DateTimeKind.Local).AddTicks(7253), "OutStock", "Quibusdam rerum eum exercitationem molestias sint sunt qui. Corporis ut ea repellendus id. Ex quisquam dolores omnis totam ex id sunt. Rerum ullam ea et reiciendis qui consequatur dolorem. Optio quos ipsa expedita est.", "Product 182", "S", "Footwear" },
                    { 183, new DateTime(2020, 7, 1, 10, 38, 57, 692, DateTimeKind.Local).AddTicks(1263), "OutStock", "Quo repellendus velit officiis aut voluptatem excepturi eius qui. Hic optio nihil mollitia consequatur est quisquam dolorum sunt. In sequi repudiandae nostrum omnis veritatis id et laudantium.", "Product 183", "M", "Outerwear" },
                    { 184, new DateTime(2020, 9, 5, 10, 38, 57, 692, DateTimeKind.Local).AddTicks(6812), "InStock", "Aut ducimus quod earum voluptatibus nesciunt quia. Consequatur consequuntur sed voluptatem suscipit. Quia deleniti occaecati distinctio impedit omnis delectus sunt. Eum quia ut nostrum reiciendis nihil ex cumque sunt. Tenetur sed sed id minus aliquid harum magni quia.", "Product 184", "M", "Accessory" },
                    { 157, new DateTime(2020, 6, 18, 10, 38, 57, 681, DateTimeKind.Local).AddTicks(5088), "OutStock", "Quisquam et officiis quidem voluptatem qui quod consequuntur. Eum eum nemo maiores quod rem porro praesentium. Et eos expedita officia.", "Product 157", "S", "Underwear" },
                    { 185, new DateTime(2020, 9, 4, 10, 38, 57, 693, DateTimeKind.Local).AddTicks(358), "OutStock", "Quia ratione voluptates voluptas sunt possimus. Quis maxime ullam odit. Quia in est voluptatum. Mollitia quam aperiam perspiciatis. Qui quo voluptatem doloremque ducimus.", "Product 185", "S", "Accessory" },
                    { 156, new DateTime(2020, 8, 16, 10, 38, 57, 681, DateTimeKind.Local).AddTicks(1697), "OutStock", "Optio quaerat ducimus recusandae quibusdam ex. Dolores perferendis et doloribus et voluptatibus. Illum omnis dicta odit. Quia enim aspernatur eos.", "Product 156", "L", "Underwear" },
                    { 154, new DateTime(2020, 8, 23, 10, 38, 57, 680, DateTimeKind.Local).AddTicks(1737), "InStock", "Ut illo nemo est harum vel ea iusto labore. Tempora ad est molestias ut sint rem. Unde alias aut tempora dolorem quod officiis. Necessitatibus molestias natus porro aut.", "Product 154", "S", "Outerwear" },
                    { 127, new DateTime(2020, 9, 5, 10, 38, 57, 664, DateTimeKind.Local).AddTicks(8801), "InStock", "Sint occaecati enim et quidem velit pariatur occaecati. Dolorem maiores id nihil. Qui vel rerum et placeat sapiente itaque iure ut. Aut dolorem facere debitis nam aut odit. Placeat aut est pariatur aspernatur nulla.", "Product 127", "XS", "Accessory" },
                    { 128, new DateTime(2020, 8, 13, 10, 38, 57, 665, DateTimeKind.Local).AddTicks(2750), "InStock", "Consequuntur exercitationem quaerat quae quisquam corrupti. Mollitia ut possimus in. Est autem nihil impedit.", "Product 128", "XS", "Footwear" },
                    { 129, new DateTime(2020, 8, 20, 10, 38, 57, 666, DateTimeKind.Local).AddTicks(962), "OutStock", "Et aliquid odit sapiente labore harum doloremque provident ea. Quidem labore atque qui est et id et. Provident dignissimos sunt itaque id culpa deserunt. Ut id beatae quibusdam consectetur dolor est sunt.", "Product 129", "S", "Accessory" },
                    { 130, new DateTime(2020, 7, 6, 10, 38, 57, 666, DateTimeKind.Local).AddTicks(6449), "OutStock", "Omnis deleniti ipsa dolorem veritatis dignissimos molestiae dolores magnam. Beatae porro quis repellendus tempore nisi sapiente molestias. Maiores molestiae nihil suscipit.", "Product 130", "M", "Underwear" },
                    { 131, new DateTime(2020, 6, 13, 10, 38, 57, 667, DateTimeKind.Local).AddTicks(3064), "OutStock", "Libero molestiae beatae doloremque corrupti fugiat. Dolore minima enim ut dolor. Vitae et consectetur veniam nihil nostrum nemo. Necessitatibus rerum ex maxime aut et vero.", "Product 131", "XS", "Footwear" },
                    { 132, new DateTime(2020, 8, 30, 10, 38, 57, 668, DateTimeKind.Local).AddTicks(1396), "OutStock", "Magni exercitationem deleniti eaque sint quaerat eum veniam tempore. Omnis culpa ea esse perspiciatis. Perspiciatis amet similique quae veniam assumenda. Expedita ut beatae minus ut. Rerum accusantium et pariatur sunt tempore.", "Product 132", "M", "Footwear" },
                    { 133, new DateTime(2020, 8, 7, 10, 38, 57, 668, DateTimeKind.Local).AddTicks(6415), "InStock", "Modi dolor quam sit distinctio quo. Quo sapiente culpa quos. Quis atque eligendi eum autem sit sunt amet.", "Product 133", "S", "Underwear" },
                    { 134, new DateTime(2020, 6, 22, 10, 38, 57, 669, DateTimeKind.Local).AddTicks(3244), "OutStock", "Quae ipsam eaque nesciunt consequatur. Nemo voluptas omnis mollitia dolorum aliquid quaerat. At sed quis tempora cupiditate voluptates facilis sed. Aut ducimus rerum ad sed ipsam. Ipsam accusamus adipisci aspernatur.", "Product 134", "S", "Outerwear" },
                    { 135, new DateTime(2020, 7, 1, 10, 38, 57, 669, DateTimeKind.Local).AddTicks(8099), "OutStock", "Libero consequuntur commodi nesciunt est ut voluptate. Atque dolorum autem dolores quae est molestias autem. Ut in et voluptatem quaerat magnam architecto dolor facilis.", "Product 135", "M", "Underwear" },
                    { 136, new DateTime(2020, 8, 7, 10, 38, 57, 670, DateTimeKind.Local).AddTicks(5538), "OutStock", "Dolorem nostrum velit consequatur qui commodi. Sunt et esse quo mollitia expedita officiis. Rerum eligendi dolores magni assumenda corrupti itaque dolorum voluptatum. Rerum reprehenderit minima sint et molestiae molestias fuga. Minima voluptates sit minima sapiente.", "Product 136", "S", "Underwear" },
                    { 137, new DateTime(2020, 7, 30, 10, 38, 57, 670, DateTimeKind.Local).AddTicks(9559), "InStock", "Quod tempora nostrum necessitatibus ipsa. Rem assumenda natus sed nisi qui error at autem. Id error similique est dignissimos.", "Product 137", "S", "Outerwear" },
                    { 138, new DateTime(2020, 9, 8, 10, 38, 57, 671, DateTimeKind.Local).AddTicks(5507), "OutStock", "Accusantium qui dolore et. Qui earum accusamus dicta ea. Iusto et odio velit beatae non ullam. Culpa iusto labore odit laudantium repellat sunt praesentium aut. Quasi ea enim libero.", "Product 138", "S", "Accessory" },
                    { 139, new DateTime(2020, 8, 20, 10, 38, 57, 671, DateTimeKind.Local).AddTicks(9958), "InStock", "Nihil dolores eveniet occaecati dolorum eum reprehenderit. Id distinctio illo unde sed fugit quas praesentium laudantium. Iste et eaque ipsum esse.", "Product 139", "XS", "Outerwear" },
                    { 140, new DateTime(2020, 8, 8, 10, 38, 57, 672, DateTimeKind.Local).AddTicks(4914), "OutStock", "Delectus impedit sit minima nesciunt dolorem et est. Est iste autem reiciendis consectetur hic ea. Aspernatur aliquam fugiat expedita sunt quia earum consectetur ut.", "Product 140", "M", "Underwear" },
                    { 141, new DateTime(2020, 7, 3, 10, 38, 57, 672, DateTimeKind.Local).AddTicks(8387), "InStock", "Alias inventore quo est rerum in. Excepturi dolorum quos ex. Id ea veritatis explicabo voluptatem incidunt.", "Product 141", "XS", "Underwear" },
                    { 142, new DateTime(2020, 9, 17, 10, 38, 57, 673, DateTimeKind.Local).AddTicks(5279), "InStock", "Doloribus porro voluptatem ipsa eaque cum magni consequatur sed. Delectus et consequuntur aliquid voluptate. Iure in rerum eum voluptatem. Et dicta omnis cumque sint explicabo alias. Qui delectus officia itaque accusantium alias temporibus velit.", "Product 142", "S", "Outerwear" },
                    { 143, new DateTime(2020, 8, 4, 10, 38, 57, 674, DateTimeKind.Local).AddTicks(1913), "OutStock", "Veniam ex quas corrupti amet tempora quae esse officia. Et maiores officiis vero. Perferendis in et doloremque possimus asperiores. Aut magni a et ab autem qui error nihil. Veritatis et rerum enim nesciunt.", "Product 143", "S", "Outerwear" },
                    { 144, new DateTime(2020, 6, 29, 10, 38, 57, 674, DateTimeKind.Local).AddTicks(8365), "InStock", "Qui consequatur aliquid sit numquam placeat. Dolore voluptate saepe magni vel nobis. Sint soluta ut distinctio repellendus. Ut a voluptatem repellendus sed totam et. Officiis vel quia voluptatem id est illum.", "Product 144", "S", "Footwear" },
                    { 145, new DateTime(2020, 9, 14, 10, 38, 57, 675, DateTimeKind.Local).AddTicks(3155), "OutStock", "Ab et corrupti sint aut delectus est saepe. Mollitia est sit libero et velit reiciendis laboriosam. Consequuntur dolores voluptas ab quidem dolorum ex.", "Product 145", "S", "Underwear" },
                    { 146, new DateTime(2020, 8, 8, 10, 38, 57, 675, DateTimeKind.Local).AddTicks(8417), "InStock", "Nihil veritatis qui quibusdam quae odio omnis. Non consequatur veniam numquam necessitatibus asperiores et. Non odio dolor alias et error. Sint qui aut quo maiores harum.", "Product 146", "L", "Underwear" },
                    { 147, new DateTime(2020, 8, 30, 10, 38, 57, 676, DateTimeKind.Local).AddTicks(5115), "InStock", "Sunt expedita maxime ea eius repellendus. Et minus et doloremque voluptatem doloremque architecto dicta. Repellat accusantium voluptas aliquid. Id qui amet labore debitis consequatur quo vel cumque. Reiciendis sed voluptates aut tempora et.", "Product 147", "S", "Footwear" },
                    { 148, new DateTime(2020, 8, 7, 10, 38, 57, 677, DateTimeKind.Local).AddTicks(2648), "OutStock", "Placeat fugit minima veniam maxime voluptas rerum fugit. Veniam accusantium aut quas facere qui libero placeat commodi. Accusamus incidunt distinctio quam et alias ad. Architecto aut odio sint sit numquam temporibus totam. Odio dolor dolorem eveniet explicabo.", "Product 148", "S", "Accessory" },
                    { 149, new DateTime(2020, 7, 25, 10, 38, 57, 677, DateTimeKind.Local).AddTicks(8469), "OutStock", "Quo et et totam ipsum. Inventore ut possimus culpa ad aperiam mollitia enim dolores. Voluptatem dolores vel facilis atque suscipit accusantium. Et autem quo nam temporibus quisquam est atque.", "Product 149", "S", "Underwear" },
                    { 150, new DateTime(2020, 9, 3, 10, 38, 57, 678, DateTimeKind.Local).AddTicks(3331), "OutStock", "Deleniti placeat ut omnis voluptas deleniti quae ratione. Dolore expedita quis dolorum et non dignissimos. Enim cupiditate dolorem autem quis. Sit voluptas sit incidunt omnis exercitationem quibusdam.", "Product 150", "S", "Accessory" },
                    { 151, new DateTime(2020, 7, 20, 10, 38, 57, 678, DateTimeKind.Local).AddTicks(8241), "InStock", "Eum aperiam provident et et vel. Doloremque velit vel repellendus est non ea. Sed doloremque aut adipisci voluptas excepturi non dolore quo. Explicabo minima vero non fugiat et.", "Product 151", "XS", "Underwear" },
                    { 152, new DateTime(2020, 7, 25, 10, 38, 57, 679, DateTimeKind.Local).AddTicks(2452), "InStock", "Distinctio est ut minima vitae commodi ex. Et repudiandae aspernatur aliquid eum necessitatibus aut earum fuga. Et cumque nihil est ea qui eveniet impedit tenetur.", "Product 152", "M", "Footwear" },
                    { 153, new DateTime(2020, 8, 18, 10, 38, 57, 679, DateTimeKind.Local).AddTicks(6918), "OutStock", "Qui est beatae voluptas. Et dolore eveniet eum excepturi molestias porro architecto. Unde id voluptatibus delectus consequatur quidem quam. Sint vitae rerum sunt maxime quia laborum consequatur.", "Product 153", "XS", "Underwear" },
                    { 155, new DateTime(2020, 7, 26, 10, 38, 57, 680, DateTimeKind.Local).AddTicks(8276), "OutStock", "Quis rerum voluptas sint illo est ut. Deleniti nihil provident facilis quidem consectetur est qui hic. Autem itaque et cum exercitationem et id eligendi excepturi. Dolorem dolor consequatur eos ut ullam ullam sint sit. Qui voluptatem esse aut velit perspiciatis.", "Product 155", "M", "Outerwear" },
                    { 186, new DateTime(2020, 8, 7, 10, 38, 57, 693, DateTimeKind.Local).AddTicks(5301), "OutStock", "Numquam blanditiis quia rem qui eveniet. Dolorem nisi velit eius nihil ex repellat corrupti et. Et quaerat dicta dolor voluptatem et expedita. Consequatur eos enim numquam incidunt. Est laborum voluptatem aut et voluptas.", "Product 186", "XS", "Footwear" },
                    { 187, new DateTime(2020, 6, 23, 10, 38, 57, 693, DateTimeKind.Local).AddTicks(9519), "OutStock", "Odit et est minima est inventore eum. Consequatur odio pariatur quo. Aut hic dolorem expedita. Repudiandae quia laborum eos sit perferendis error. Quaerat mollitia qui sunt quos eaque.", "Product 187", "XS", "Accessory" },
                    { 188, new DateTime(2020, 9, 2, 10, 38, 57, 694, DateTimeKind.Local).AddTicks(3438), "InStock", "Facilis officiis consequatur animi ipsa nisi. Sed quo quo a similique molestias nemo voluptatem. Et eligendi et neque et commodi. Quo consequuntur non earum maxime adipisci.", "Product 188", "L", "Underwear" },
                    { 221, new DateTime(2020, 7, 24, 10, 38, 57, 805, DateTimeKind.Local).AddTicks(2923), "OutStock", "Quia repudiandae qui ut delectus odit earum. Harum rem reprehenderit cum. Dolorem omnis qui ab molestiae quia.", "Product 221", "M", "Underwear" },
                    { 222, new DateTime(2020, 9, 13, 10, 38, 57, 805, DateTimeKind.Local).AddTicks(8997), "OutStock", "Quisquam et dicta quia saepe non nihil. Dolores error aut officia autem. Nostrum delectus cupiditate iure iusto voluptatum sed. Et eveniet nobis hic libero architecto repudiandae.", "Product 222", "M", "Footwear" },
                    { 223, new DateTime(2020, 8, 22, 10, 38, 57, 806, DateTimeKind.Local).AddTicks(3364), "InStock", "Optio sint aut modi qui. Voluptas vitae saepe ea. Omnis eveniet explicabo ut rem porro minima nisi odio.", "Product 223", "XS", "Accessory" },
                    { 224, new DateTime(2020, 7, 28, 10, 38, 57, 806, DateTimeKind.Local).AddTicks(9710), "OutStock", "Non similique accusamus ut est. Est odit quia quis et eum ea. Consequatur velit similique beatae officiis aperiam nobis corrupti sequi. Eius rerum corrupti blanditiis nostrum autem sunt.", "Product 224", "L", "Footwear" },
                    { 225, new DateTime(2020, 8, 29, 10, 38, 57, 807, DateTimeKind.Local).AddTicks(4482), "InStock", "Aperiam odio ad nesciunt. Omnis eligendi modi iusto omnis cumque et. Voluptates ipsam dolores facere et ut molestiae consequatur illo.", "Product 225", "XS", "Accessory" },
                    { 226, new DateTime(2020, 8, 29, 10, 38, 57, 807, DateTimeKind.Local).AddTicks(8605), "OutStock", "Eligendi quidem amet dolores perspiciatis libero. Est qui autem molestiae incidunt voluptatem et. Id vel delectus natus.", "Product 226", "M", "Outerwear" },
                    { 227, new DateTime(2020, 6, 27, 10, 38, 57, 808, DateTimeKind.Local).AddTicks(6129), "InStock", "Non est eaque quo et ipsam porro repudiandae. Ut iusto ab quisquam cupiditate quia dolores nisi velit. Dolor qui ut natus sit at natus occaecati. Dicta saepe ex dolorem delectus unde omnis facere.", "Product 227", "S", "Footwear" },
                    { 228, new DateTime(2020, 7, 13, 10, 38, 57, 809, DateTimeKind.Local).AddTicks(2040), "OutStock", "Qui aliquam inventore et blanditiis praesentium. Cumque est aut id perspiciatis occaecati quis nostrum molestias. Illum voluptatem veniam ut assumenda non. Nostrum vero commodi officia.", "Product 228", "S", "Footwear" },
                    { 229, new DateTime(2020, 7, 21, 10, 38, 57, 809, DateTimeKind.Local).AddTicks(7478), "OutStock", "Eos et veritatis molestiae iusto aut. Magnam ut veritatis ea. Quia alias molestias assumenda vel nam. Maiores ut quam vel ratione neque nulla.", "Product 229", "XS", "Footwear" },
                    { 230, new DateTime(2020, 9, 7, 10, 38, 57, 810, DateTimeKind.Local).AddTicks(2712), "InStock", "Velit facere suscipit laborum dolorem omnis aut ratione necessitatibus. Velit rem sint ex sequi sed dolor fugiat. Corrupti at ducimus incidunt adipisci.", "Product 230", "S", "Outerwear" },
                    { 231, new DateTime(2020, 8, 11, 10, 38, 57, 810, DateTimeKind.Local).AddTicks(9639), "InStock", "Est et iste sit. Consequatur dicta pariatur est vel commodi. Aut aliquid eum et consectetur ut hic aperiam. Nulla earum deleniti voluptatem voluptatum adipisci. Sequi temporibus aut fugiat dolores inventore tempora.", "Product 231", "XS", "Underwear" },
                    { 232, new DateTime(2020, 7, 31, 10, 38, 57, 811, DateTimeKind.Local).AddTicks(5697), "InStock", "Est nobis velit occaecati omnis omnis fugiat. Dignissimos sapiente occaecati qui voluptatem. Cum rem harum sequi et quia est vel labore. Inventore tempore porro aut aut.", "Product 232", "L", "Outerwear" },
                    { 233, new DateTime(2020, 7, 6, 10, 38, 57, 811, DateTimeKind.Local).AddTicks(9163), "OutStock", "Quo cumque molestiae ab. Pariatur consequatur totam quas. Deserunt voluptatem et vel in nihil.", "Product 233", "S", "Outerwear" },
                    { 234, new DateTime(2020, 6, 25, 10, 38, 57, 812, DateTimeKind.Local).AddTicks(7095), "InStock", "Praesentium sint nisi consectetur deserunt nihil neque. Ad aut mollitia rerum ducimus et. Voluptatem doloremque aut occaecati magni quia voluptatem. Qui sed deleniti cupiditate aut rem nobis optio saepe. Perferendis cupiditate qui quis molestiae quia.", "Product 234", "S", "Underwear" },
                    { 235, new DateTime(2020, 9, 15, 10, 38, 57, 813, DateTimeKind.Local).AddTicks(715), "InStock", "Odit porro autem animi quidem architecto. Laborum autem assumenda eligendi. Quia officiis deleniti et.", "Product 235", "L", "Underwear" },
                    { 236, new DateTime(2020, 8, 28, 10, 38, 57, 813, DateTimeKind.Local).AddTicks(5011), "InStock", "Libero nesciunt repellendus quidem. Eius consequuntur enim nam rerum ratione. Animi non dolore cupiditate et doloremque facere ipsam.", "Product 236", "XS", "Outerwear" },
                    { 237, new DateTime(2020, 8, 22, 10, 38, 57, 814, DateTimeKind.Local).AddTicks(2263), "InStock", "Non dolorem aut ut ut eligendi. Atque sed corrupti nisi debitis ut sed. Ut inventore adipisci assumenda perferendis quis repellat ullam. Ut sit aut et. Laborum reprehenderit consectetur sint ut hic dicta.", "Product 237", "L", "Accessory" },
                    { 238, new DateTime(2020, 6, 16, 10, 38, 57, 815, DateTimeKind.Local).AddTicks(515), "OutStock", "Velit non ut et est incidunt autem adipisci veritatis. Veritatis dolor in earum quisquam assumenda. Et ipsa excepturi et dolorum non voluptate. Esse et eos nulla et aliquid quasi. Magnam id ex est ipsa repudiandae sunt sed.", "Product 238", "XS", "Underwear" },
                    { 239, new DateTime(2020, 9, 18, 10, 38, 57, 815, DateTimeKind.Local).AddTicks(6026), "InStock", "Assumenda aut earum ut voluptate fuga animi iusto modi. Officiis consectetur laborum optio recusandae ipsum exercitationem corporis. Ut officiis ex sint ipsum ratione quo.", "Product 239", "L", "Outerwear" },
                    { 240, new DateTime(2020, 6, 28, 10, 38, 57, 815, DateTimeKind.Local).AddTicks(9564), "InStock", "Accusamus odio recusandae dolorem. Sit id deleniti modi qui quo. Perferendis repudiandae ullam et.", "Product 240", "M", "Outerwear" },
                    { 241, new DateTime(2020, 6, 19, 10, 38, 57, 816, DateTimeKind.Local).AddTicks(7047), "OutStock", "Et ducimus ipsum sint et ut officiis et est. Quo corporis et molestiae accusamus enim ea temporibus. Quas sequi et atque eum. Qui qui ea cumque quas repudiandae. Fugit et totam possimus qui.", "Product 241", "XS", "Outerwear" },
                    { 242, new DateTime(2020, 6, 16, 10, 38, 57, 817, DateTimeKind.Local).AddTicks(2504), "InStock", "Exercitationem totam officia ex quos dolorem. Quaerat dicta cumque accusantium illum recusandae. Ipsum aperiam facilis non aut inventore ipsam ut. Dignissimos possimus deleniti rerum veritatis.", "Product 242", "M", "Underwear" },
                    { 243, new DateTime(2020, 7, 13, 10, 38, 57, 817, DateTimeKind.Local).AddTicks(8906), "OutStock", "Quasi ea doloremque quisquam omnis. Aperiam nemo optio earum consequatur facere quibusdam. Architecto consequatur voluptas facere. Quia ab voluptatem ea tenetur sed. Cum dolor alias id qui amet aut totam sit.", "Product 243", "S", "Underwear" },
                    { 244, new DateTime(2020, 7, 18, 10, 38, 57, 818, DateTimeKind.Local).AddTicks(5055), "OutStock", "Nihil sunt eius officia architecto et voluptates aut. Dolore rem sit sit. Earum quia odio quam inventore inventore omnis. Aliquam nostrum deleniti blanditiis voluptas ea. Eligendi hic in qui.", "Product 244", "S", "Accessory" },
                    { 245, new DateTime(2020, 9, 8, 10, 38, 57, 819, DateTimeKind.Local).AddTicks(1703), "OutStock", "Accusamus saepe dolores omnis. Facere laborum quibusdam nobis consectetur est et dolorem. Deserunt ullam minima autem saepe incidunt accusantium. Odio fugiat temporibus asperiores eos praesentium. Laudantium velit quia deserunt mollitia labore doloribus.", "Product 245", "M", "Underwear" },
                    { 246, new DateTime(2020, 8, 7, 10, 38, 57, 819, DateTimeKind.Local).AddTicks(7506), "InStock", "Voluptatem aspernatur tenetur mollitia nobis autem aut quo voluptas. Accusamus qui non sit modi. Enim deserunt totam ab consequatur. Totam eius rerum et dolor est doloremque eligendi aliquam.", "Product 246", "M", "Underwear" },
                    { 247, new DateTime(2020, 7, 24, 10, 38, 57, 820, DateTimeKind.Local).AddTicks(4376), "OutStock", "Recusandae velit veniam nesciunt est voluptas ut mollitia quas. Neque quidem eveniet incidunt officia. Quia dolores et exercitationem. Commodi quo voluptatem soluta magni dolor. Voluptatum quaerat ut ratione est et quia repellat consectetur.", "Product 247", "L", "Footwear" },
                    { 220, new DateTime(2020, 8, 21, 10, 38, 57, 804, DateTimeKind.Local).AddTicks(8258), "OutStock", "Aperiam labore id voluptatem rerum corporis reprehenderit. Sed corporis sapiente recusandae tenetur laudantium ea. Facere eos aliquam odit quam.", "Product 220", "M", "Underwear" },
                    { 219, new DateTime(2020, 6, 28, 10, 38, 57, 804, DateTimeKind.Local).AddTicks(3731), "OutStock", "Laborum porro et perspiciatis cupiditate veniam iure. Tenetur et deserunt repellat odit et rem. Quas est ad et tenetur id similique et.", "Product 219", "M", "Accessory" },
                    { 218, new DateTime(2020, 8, 6, 10, 38, 57, 803, DateTimeKind.Local).AddTicks(8438), "OutStock", "Molestias eaque corrupti dolores hic illo voluptatum sit. Reiciendis voluptas aut molestiae repudiandae ullam nobis veniam vel. Voluptate enim aut vel eum expedita sapiente atque. Est reiciendis nihil vel ut ut.", "Product 218", "M", "Accessory" },
                    { 217, new DateTime(2020, 8, 19, 10, 38, 57, 803, DateTimeKind.Local).AddTicks(1514), "OutStock", "Nihil corporis ullam amet dolor ducimus qui. Sed dolores necessitatibus eaque quis. Exercitationem velit placeat aspernatur eum pariatur. Autem neque libero exercitationem veniam voluptatem reprehenderit. Rerum non qui commodi est.", "Product 217", "S", "Outerwear" },
                    { 189, new DateTime(2020, 8, 15, 10, 38, 57, 694, DateTimeKind.Local).AddTicks(7915), "OutStock", "Nobis quo fugiat tenetur fugiat quos. Consequatur et id quod. Temporibus neque qui quae blanditiis. Earum amet deserunt quidem porro quaerat officiis at. Reiciendis impedit quod porro omnis consequuntur mollitia.", "Product 189", "XS", "Outerwear" },
                    { 190, new DateTime(2020, 8, 3, 10, 38, 57, 695, DateTimeKind.Local).AddTicks(3150), "OutStock", "Assumenda labore perspiciatis debitis minima quae molestiae. Harum reprehenderit id eum quia. Doloribus molestiae autem accusamus qui suscipit voluptas nostrum. Veritatis quasi non et. Eum minima consequatur eligendi sunt et omnis enim ipsa.", "Product 190", "S", "Accessory" },
                    { 191, new DateTime(2020, 7, 31, 10, 38, 57, 695, DateTimeKind.Local).AddTicks(6686), "OutStock", "Soluta magnam molestiae eum incidunt numquam ut mollitia beatae. Aspernatur est ex numquam illum quod quaerat aspernatur iste. Incidunt delectus iure ut unde.", "Product 191", "S", "Outerwear" },
                    { 192, new DateTime(2020, 6, 30, 10, 38, 57, 696, DateTimeKind.Local).AddTicks(1476), "InStock", "Commodi quam dolor pariatur tempore nisi nisi est debitis. Nisi esse sunt repellat deserunt sit qui repellendus optio. Illo laudantium quisquam architecto unde dolores quidem. Sed sequi provident qui qui eaque hic.", "Product 192", "M", "Accessory" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Arrived", "Availability", "Description", "Name", "Size", "Type" },
                values: new object[,]
                {
                    { 193, new DateTime(2020, 8, 5, 10, 38, 57, 696, DateTimeKind.Local).AddTicks(6279), "InStock", "Et aliquam dolores sint quasi non. Aut asperiores aspernatur dolorem eos et asperiores aliquid. Voluptate sed sequi ut et. Omnis similique aut occaecati voluptates aut et. Tenetur vel voluptas dolores non sed.", "Product 193", "XS", "Footwear" },
                    { 194, new DateTime(2020, 8, 13, 10, 38, 57, 696, DateTimeKind.Local).AddTicks(9880), "InStock", "Eum culpa natus ea cum alias. Ut sint omnis illo sunt non. Nihil ad explicabo repellat voluptatem et. Molestias assumenda illum velit.", "Product 194", "S", "Underwear" },
                    { 195, new DateTime(2020, 7, 3, 10, 38, 57, 697, DateTimeKind.Local).AddTicks(4293), "InStock", "Quis ad sed velit optio quidem. Tenetur minus voluptatum repudiandae placeat earum facere ratione reprehenderit. Optio sit illum velit tempore ad voluptas quisquam deserunt. Laudantium sed dolorem assumenda ex.", "Product 195", "M", "Footwear" },
                    { 196, new DateTime(2020, 7, 14, 10, 38, 57, 697, DateTimeKind.Local).AddTicks(7225), "InStock", "Tempora aliquid iusto quod. Et magnam perspiciatis dolorem ut et eaque magni. Vitae inventore sint rerum eum doloribus ullam.", "Product 196", "M", "Underwear" },
                    { 197, new DateTime(2020, 8, 6, 10, 38, 57, 698, DateTimeKind.Local).AddTicks(2689), "OutStock", "Quia sed expedita magnam aut ab. Culpa suscipit libero dolor incidunt et dicta sed. Sit sunt ex qui magni est beatae blanditiis consequatur. Quidem recusandae vel quasi distinctio sequi natus natus ducimus. Fugiat molestiae eius ipsam distinctio.", "Product 197", "M", "Underwear" },
                    { 198, new DateTime(2020, 8, 1, 10, 38, 57, 698, DateTimeKind.Local).AddTicks(8119), "OutStock", "Esse esse unde reiciendis praesentium corporis et facere. Harum delectus nobis animi aut tenetur quam. Inventore ut officia mollitia quos aut officiis. Sed vitae rem voluptatem et eius ut dolorem nobis. Natus fugit ut consequatur ea blanditiis.", "Product 198", "S", "Outerwear" },
                    { 199, new DateTime(2020, 9, 7, 10, 38, 57, 699, DateTimeKind.Local).AddTicks(3244), "InStock", "Aut qui laudantium voluptas porro occaecati. Qui dignissimos quibusdam cum quia aut ipsum et sit. Amet et in harum quibusdam atque alias. Vel provident aut repellat magnam. Ab quod consequuntur ex nemo et consectetur.", "Product 199", "L", "Outerwear" },
                    { 200, new DateTime(2020, 7, 22, 10, 38, 57, 699, DateTimeKind.Local).AddTicks(6457), "OutStock", "Voluptatem beatae facere ratione inventore voluptates repellendus. Aut quia voluptate aspernatur perferendis ut. Non animi quia ad eum illo iure maxime.", "Product 200", "M", "Underwear" },
                    { 201, new DateTime(2020, 8, 30, 10, 38, 57, 700, DateTimeKind.Local).AddTicks(609), "OutStock", "Velit eveniet molestias cum corrupti esse tempore. Delectus doloribus voluptates error rerum. Sunt voluptatem error nemo expedita aut recusandae quidem. Consectetur praesentium sit esse ea accusamus laudantium.", "Product 201", "XS", "Accessory" },
                    { 126, new DateTime(2020, 6, 14, 10, 38, 57, 664, DateTimeKind.Local).AddTicks(146), "OutStock", "Est maxime ipsa facilis cumque saepe. Blanditiis voluptatem id quia eos. Vel sit omnis assumenda dolores consequatur est magni earum. Voluptatem deleniti ut nam impedit voluptatem qui. Repellendus id consectetur officiis harum.", "Product 126", "L", "Accessory" },
                    { 202, new DateTime(2020, 7, 24, 10, 38, 57, 700, DateTimeKind.Local).AddTicks(4212), "InStock", "Qui hic hic eaque consectetur officiis quod consequatur soluta. Est distinctio officiis numquam odit recusandae. Unde voluptate officia aut. Reprehenderit consequatur repudiandae modi rerum.", "Product 202", "S", "Outerwear" },
                    { 204, new DateTime(2020, 6, 26, 10, 38, 57, 701, DateTimeKind.Local).AddTicks(434), "InStock", "Aliquam omnis illo impedit fugiat quis. Culpa aut rem dicta. Hic eaque quasi sed eligendi aut in.", "Product 204", "S", "Accessory" },
                    { 205, new DateTime(2020, 9, 5, 10, 38, 57, 795, DateTimeKind.Local).AddTicks(3519), "InStock", "Recusandae rerum facere delectus et qui impedit distinctio ipsa. Atque repudiandae est qui consequuntur veniam quis. Ut aut impedit beatae quod. Voluptatem accusantium sit natus veritatis quia vero autem praesentium. Rerum dolor iusto quis id fuga molestiae.", "Product 205", "XS", "Outerwear" },
                    { 206, new DateTime(2020, 8, 19, 10, 38, 57, 796, DateTimeKind.Local).AddTicks(3353), "OutStock", "Nemo voluptate enim non autem consequuntur eveniet. Et ea dolores dolores ut. Ut sint soluta officia nemo illum earum est. Magni ipsa quia nihil expedita. Quia inventore error pariatur debitis exercitationem sint corporis inventore.", "Product 206", "L", "Accessory" },
                    { 207, new DateTime(2020, 7, 31, 10, 38, 57, 796, DateTimeKind.Local).AddTicks(8620), "OutStock", "Voluptatem facilis autem provident voluptas dicta et unde. Sint saepe sit repudiandae quaerat. Illum qui nulla consequatur suscipit expedita dolores quaerat reprehenderit.", "Product 207", "M", "Accessory" },
                    { 208, new DateTime(2020, 6, 18, 10, 38, 57, 797, DateTimeKind.Local).AddTicks(4679), "InStock", "Accusantium sit beatae explicabo. Eligendi repellat excepturi in quia. Et alias eum aut quo. Cumque quis alias est ratione eveniet et. Et optio qui dolorum.", "Product 208", "S", "Outerwear" },
                    { 209, new DateTime(2020, 8, 2, 10, 38, 57, 798, DateTimeKind.Local).AddTicks(1546), "OutStock", "Recusandae quas iste maiores. Consequatur sapiente quae sunt est. Aut natus odio aut. Tempore quod repellat ad voluptas facilis minus quod. Laborum dolores dicta optio qui quia alias a alias.", "Product 209", "S", "Underwear" },
                    { 210, new DateTime(2020, 7, 10, 10, 38, 57, 798, DateTimeKind.Local).AddTicks(8166), "InStock", "Iusto saepe non ut qui. Numquam eveniet debitis consequuntur ipsam et. Vero maxime ut odio quis et asperiores ipsa ipsam. Quo ipsum quis ab et et inventore sed nostrum.", "Product 210", "XS", "Footwear" },
                    { 211, new DateTime(2020, 8, 14, 10, 38, 57, 799, DateTimeKind.Local).AddTicks(6531), "OutStock", "Ducimus placeat ex qui rem. Aut ab et eos magni consequatur voluptatum minus. Commodi unde nesciunt aut neque maxime voluptas. Laborum dolorem tempora quos possimus autem quaerat exercitationem pariatur. Accusantium veritatis at aliquid et commodi quam voluptas.", "Product 211", "XS", "Footwear" },
                    { 212, new DateTime(2020, 9, 12, 10, 38, 57, 800, DateTimeKind.Local).AddTicks(929), "OutStock", "Debitis reprehenderit veritatis animi. Doloribus ut iusto aliquid eligendi modi laboriosam eos. Illum commodi dolorem ea praesentium.", "Product 212", "S", "Accessory" },
                    { 213, new DateTime(2020, 8, 26, 10, 38, 57, 800, DateTimeKind.Local).AddTicks(6271), "OutStock", "Doloremque voluptates tempore aut totam id quasi. Explicabo ad perferendis omnis sint voluptatem harum et. Incidunt ut saepe mollitia nihil quo sit incidunt.", "Product 213", "S", "Underwear" },
                    { 214, new DateTime(2020, 8, 7, 10, 38, 57, 801, DateTimeKind.Local).AddTicks(1961), "InStock", "Molestiae similique deleniti quia cum harum quod. Animi ut reprehenderit veniam eligendi. Et et ipsam voluptatibus. Alias nostrum qui harum et nisi nisi ut.", "Product 214", "M", "Underwear" },
                    { 215, new DateTime(2020, 9, 4, 10, 38, 57, 801, DateTimeKind.Local).AddTicks(8383), "InStock", "Nobis iusto ipsa id laborum. Sunt fugiat quae et voluptas sed nobis fuga eos. Voluptas qui ea consequatur blanditiis. Occaecati facilis velit iure quia deserunt qui occaecati ad.", "Product 215", "S", "Underwear" },
                    { 216, new DateTime(2020, 6, 19, 10, 38, 57, 802, DateTimeKind.Local).AddTicks(4586), "OutStock", "Eveniet nulla rerum deserunt. Laborum sit nam eum rerum officiis. In ex sed provident omnis at a adipisci eos. Perferendis voluptatem odio blanditiis qui rerum maiores minima.", "Product 216", "XS", "Footwear" },
                    { 203, new DateTime(2020, 8, 7, 10, 38, 57, 700, DateTimeKind.Local).AddTicks(7768), "InStock", "Aliquam aliquam culpa consequatur unde molestiae quam quam. Est quis ratione libero. Eos quia sunt asperiores eos facere voluptas. Et voluptatum quos eveniet.", "Product 203", "L", "Underwear" },
                    { 248, new DateTime(2020, 9, 16, 10, 38, 57, 820, DateTimeKind.Local).AddTicks(9109), "InStock", "Et a id voluptas autem a voluptatibus. Error perferendis qui saepe minima aspernatur. Et ut reprehenderit nobis et ut magnam non sit.", "Product 248", "L", "Underwear" },
                    { 125, new DateTime(2020, 7, 16, 10, 38, 57, 663, DateTimeKind.Local).AddTicks(1916), "InStock", "Suscipit dolor in nam qui. Soluta pariatur consequatur necessitatibus illo. Harum eaque hic quidem sit voluptate est ipsum.", "Product 125", "S", "Underwear" },
                    { 123, new DateTime(2020, 7, 12, 10, 38, 57, 662, DateTimeKind.Local).AddTicks(1828), "OutStock", "Laboriosam possimus aspernatur consequatur voluptatem. Aut sit eum et illo rerum. Tempora voluptatem quaerat deserunt. Consequuntur enim at repellat eveniet ut.", "Product 123", "M", "Outerwear" },
                    { 33, new DateTime(2020, 7, 13, 10, 38, 57, 599, DateTimeKind.Local).AddTicks(8896), "InStock", "Impedit hic provident eaque. Deleniti minus et magnam quia aut nihil corporis. Quisquam accusantium aut et voluptas maxime sint mollitia.", "Product 33", "M", "Accessory" },
                    { 34, new DateTime(2020, 9, 9, 10, 38, 57, 600, DateTimeKind.Local).AddTicks(4236), "OutStock", "Deleniti suscipit placeat officiis veritatis sint id. Laudantium fuga asperiores quisquam illo ratione laboriosam. Eum consequuntur ea saepe aliquam amet.", "Product 34", "S", "Outerwear" },
                    { 35, new DateTime(2020, 7, 14, 10, 38, 57, 601, DateTimeKind.Local).AddTicks(1100), "InStock", "Et sed labore doloremque dolore est sit voluptatem. Consequuntur est ducimus corrupti. Molestiae quas consequatur id officiis dignissimos. Praesentium quae cupiditate sunt enim ut quo facilis corporis.", "Product 35", "L", "Accessory" },
                    { 36, new DateTime(2020, 6, 12, 10, 38, 57, 601, DateTimeKind.Local).AddTicks(7195), "OutStock", "Repellat nihil quos minus. Qui voluptatum aliquid perspiciatis non reiciendis reprehenderit earum quaerat. Aut ut blanditiis rerum corporis expedita. Velit nihil et doloribus.", "Product 36", "L", "Footwear" },
                    { 37, new DateTime(2020, 7, 31, 10, 38, 57, 602, DateTimeKind.Local).AddTicks(1553), "OutStock", "Ea aspernatur et quis. Qui alias sit vitae in aut. Facilis modi ipsum debitis quos amet.", "Product 37", "L", "Accessory" },
                    { 38, new DateTime(2020, 7, 19, 10, 38, 57, 602, DateTimeKind.Local).AddTicks(6677), "InStock", "Et excepturi animi deleniti aut dolores. Deserunt est occaecati qui. Aut quibusdam voluptatibus quo ut explicabo voluptatem perspiciatis aperiam.", "Product 38", "XS", "Accessory" },
                    { 39, new DateTime(2020, 6, 23, 10, 38, 57, 603, DateTimeKind.Local).AddTicks(2872), "OutStock", "Officia laboriosam aut delectus in nulla sunt. Voluptatem et dignissimos ad. Iusto ab aut voluptate. Expedita non unde minus dolorum non voluptatem cum fuga.", "Product 39", "L", "Footwear" },
                    { 40, new DateTime(2020, 6, 18, 10, 38, 57, 604, DateTimeKind.Local).AddTicks(649), "OutStock", "Fugit eaque est nostrum et at dolorum quas. Voluptatem odit consequatur accusamus non nostrum repudiandae animi. Odio sunt dolor natus delectus consequatur quia. Recusandae esse iusto in. Maiores maxime esse soluta.", "Product 40", "M", "Underwear" },
                    { 41, new DateTime(2020, 6, 30, 10, 38, 57, 604, DateTimeKind.Local).AddTicks(6498), "InStock", "Asperiores voluptatum soluta asperiores saepe. A voluptatem et non sit inventore doloremque mollitia omnis. Quia quibusdam et rem. Earum velit enim odit.", "Product 41", "L", "Underwear" },
                    { 42, new DateTime(2020, 8, 3, 10, 38, 57, 605, DateTimeKind.Local).AddTicks(4215), "InStock", "Cum quis sint numquam quibusdam dolorem qui. Corrupti rerum unde ut rerum vitae est dolorum alias. Rerum exercitationem exercitationem dolorum doloribus. Laborum et quia consequatur illum dolorum deleniti ut saepe.", "Product 42", "XS", "Footwear" },
                    { 43, new DateTime(2020, 9, 7, 10, 38, 57, 606, DateTimeKind.Local).AddTicks(2831), "OutStock", "Non autem minus impedit. Quisquam id quae quo numquam aut nemo aut. Est quasi autem velit quo officia et. Sit similique sit ullam assumenda officia illo quidem. Voluptatem quia voluptas libero sit aut debitis.", "Product 43", "M", "Underwear" },
                    { 44, new DateTime(2020, 7, 13, 10, 38, 57, 606, DateTimeKind.Local).AddTicks(8122), "InStock", "Deserunt sint omnis tempora eaque optio. Perspiciatis impedit voluptatem optio quisquam quo ratione ad et. Ducimus molestias eaque cum reiciendis.", "Product 44", "XS", "Underwear" },
                    { 45, new DateTime(2020, 9, 8, 10, 38, 57, 607, DateTimeKind.Local).AddTicks(5825), "OutStock", "Culpa placeat nobis alias laborum dicta. Sunt similique dignissimos sapiente. Distinctio accusantium ratione odio qui minus. Et quas eaque laboriosam iure molestias est deserunt. Commodi pariatur commodi qui dolor sed.", "Product 45", "L", "Underwear" },
                    { 46, new DateTime(2020, 8, 7, 10, 38, 57, 608, DateTimeKind.Local).AddTicks(3497), "OutStock", "Omnis rerum amet qui. Et iste consequatur velit est aliquid est vel porro. Distinctio harum fugit in nesciunt aliquam aut dignissimos aperiam. Delectus quos dolorem accusamus praesentium commodi ipsam veniam.", "Product 46", "S", "Footwear" },
                    { 47, new DateTime(2020, 6, 27, 10, 38, 57, 609, DateTimeKind.Local).AddTicks(1650), "InStock", "Est odit distinctio voluptate delectus explicabo eum. Laudantium mollitia eos repellat inventore. Quaerat quia ex unde corrupti temporibus. Ut rem ex est dignissimos ratione neque totam. Porro sunt qui placeat recusandae totam.", "Product 47", "XS", "Accessory" },
                    { 48, new DateTime(2020, 8, 10, 10, 38, 57, 609, DateTimeKind.Local).AddTicks(8286), "InStock", "Deserunt dolor sit exercitationem porro. Dicta beatae omnis et fugit suscipit velit. Non omnis nostrum saepe occaecati nihil ut et itaque. Sequi aliquam ut totam dolores.", "Product 48", "L", "Underwear" },
                    { 49, new DateTime(2020, 9, 15, 10, 38, 57, 610, DateTimeKind.Local).AddTicks(5604), "OutStock", "Suscipit modi odio et et magnam quibusdam autem quo. Sint provident ut maxime at quia velit expedita. Tempora id impedit dolores sed voluptas veritatis. Culpa deserunt animi aspernatur.", "Product 49", "M", "Footwear" },
                    { 50, new DateTime(2020, 7, 22, 10, 38, 57, 611, DateTimeKind.Local).AddTicks(1844), "InStock", "Iure corrupti mollitia est amet autem error nemo. Saepe sit laudantium ipsam at aut eveniet et aut. Velit labore consequuntur enim voluptatem pariatur aliquam.", "Product 50", "S", "Accessory" },
                    { 51, new DateTime(2020, 9, 5, 10, 38, 57, 611, DateTimeKind.Local).AddTicks(9033), "InStock", "Officiis et voluptatem quia exercitationem quidem. Sunt cupiditate nemo iure. Beatae in necessitatibus quis quo dolores non maxime. Laboriosam quo rerum corporis mollitia. Ipsum quasi molestiae suscipit neque.", "Product 51", "L", "Outerwear" },
                    { 52, new DateTime(2020, 7, 26, 10, 38, 57, 612, DateTimeKind.Local).AddTicks(5591), "InStock", "Maiores quas rerum dolor. Atque placeat perspiciatis sint excepturi nesciunt vero. Perferendis vero nihil iste cupiditate provident molestias aut fugit. Amet dolor soluta qui officiis.", "Product 52", "S", "Underwear" },
                    { 53, new DateTime(2020, 6, 26, 10, 38, 57, 613, DateTimeKind.Local).AddTicks(3862), "OutStock", "Ut debitis reprehenderit aut nemo qui ipsum reiciendis quia. Quasi vel perspiciatis quia. Cum esse modi rerum dolorem. Sunt accusantium expedita eum quia illo. Iste adipisci aperiam ut enim dolores sed rerum.", "Product 53", "M", "Accessory" },
                    { 54, new DateTime(2020, 8, 2, 10, 38, 57, 613, DateTimeKind.Local).AddTicks(9616), "OutStock", "Deleniti laboriosam eum nisi. Vitae dolor ea iste. Iusto dolorum quam ea quo quaerat aspernatur. Saepe est vel sint est facilis aut.", "Product 54", "L", "Underwear" },
                    { 55, new DateTime(2020, 7, 23, 10, 38, 57, 614, DateTimeKind.Local).AddTicks(8909), "OutStock", "Quidem harum accusamus quis officia perspiciatis. Sint qui quia est non. Excepturi et eligendi voluptates et expedita inventore perferendis. Culpa a voluptatibus cumque voluptatem ea deleniti quia sequi. Ut cupiditate non dolor sed qui odit laudantium.", "Product 55", "L", "Outerwear" },
                    { 56, new DateTime(2020, 6, 14, 10, 38, 57, 615, DateTimeKind.Local).AddTicks(4104), "OutStock", "Ea aperiam recusandae debitis suscipit. Qui ratione natus voluptas. Animi occaecati aperiam sed quaerat. Voluptate incidunt et atque qui.", "Product 56", "S", "Accessory" },
                    { 57, new DateTime(2020, 6, 19, 10, 38, 57, 616, DateTimeKind.Local).AddTicks(749), "OutStock", "Deserunt et est omnis deleniti. Magni delectus nisi quia. Est maiores aut quisquam autem eius dolorem vel. Fugit accusantium numquam aliquid corporis et nulla maxime sint.", "Product 57", "L", "Footwear" },
                    { 58, new DateTime(2020, 7, 2, 10, 38, 57, 616, DateTimeKind.Local).AddTicks(5104), "InStock", "Esse dolores explicabo impedit est est. Nemo provident ex sunt reiciendis eos. Omnis et et cumque.", "Product 58", "L", "Footwear" },
                    { 59, new DateTime(2020, 8, 11, 10, 38, 57, 616, DateTimeKind.Local).AddTicks(9965), "InStock", "At laudantium dolore reprehenderit laborum. Dolorum voluptatem labore doloribus ut quibusdam autem omnis vitae. Dolorem ex et aut.", "Product 59", "M", "Accessory" },
                    { 32, new DateTime(2020, 7, 8, 10, 38, 57, 599, DateTimeKind.Local).AddTicks(3284), "OutStock", "Temporibus omnis nulla dolore quod iusto quidem. Nulla rerum eius quia fuga ratione eaque. Nulla ratione praesentium perferendis. Autem officia hic voluptates aut optio. Dolor placeat sit magnam earum rem.", "Product 32", "M", "Outerwear" },
                    { 60, new DateTime(2020, 8, 30, 10, 38, 57, 617, DateTimeKind.Local).AddTicks(3925), "OutStock", "Quaerat porro nemo voluptatum. Officia unde ea labore quae. Et est ut placeat omnis.", "Product 60", "S", "Underwear" },
                    { 31, new DateTime(2020, 6, 30, 10, 38, 57, 598, DateTimeKind.Local).AddTicks(5506), "OutStock", "Cupiditate earum neque debitis. Est sapiente eligendi velit. Porro fugit voluptas fugit nihil sed.", "Product 31", "M", "Accessory" },
                    { 29, new DateTime(2020, 7, 2, 10, 38, 57, 597, DateTimeKind.Local).AddTicks(4438), "OutStock", "Suscipit quo ullam in et culpa. Nostrum ut aut nesciunt illo et aut. Et molestiae adipisci ut voluptatibus dolor at.", "Product 29", "S", "Outerwear" },
                    { 2, new DateTime(2020, 6, 24, 10, 38, 57, 580, DateTimeKind.Local).AddTicks(5731), "OutStock", "Placeat deleniti et explicabo temporibus sint ut. Sapiente sit porro corrupti recusandae sint excepturi. Nisi non quidem vitae architecto placeat quam magni.", "Product 2", "M", "Underwear" },
                    { 3, new DateTime(2020, 9, 1, 10, 38, 57, 581, DateTimeKind.Local).AddTicks(2248), "OutStock", "Qui praesentium in dolorum quae suscipit. Ducimus voluptatem unde quo architecto accusantium cupiditate molestiae. Iste totam debitis quisquam enim. Enim reprehenderit id voluptatem non nihil et et voluptas.", "Product 3", "XS", "Accessory" },
                    { 4, new DateTime(2020, 8, 9, 10, 38, 57, 581, DateTimeKind.Local).AddTicks(8162), "InStock", "In magnam distinctio harum inventore perspiciatis blanditiis. Eveniet non voluptatem temporibus. Assumenda consectetur illum nemo autem. Asperiores quibusdam et odit excepturi magnam dolorum iusto mollitia.", "Product 4", "M", "Underwear" },
                    { 5, new DateTime(2020, 9, 9, 10, 38, 57, 582, DateTimeKind.Local).AddTicks(2838), "InStock", "Quia alias nostrum excepturi et repudiandae. Ipsam porro quia est ut. Similique iste aliquam ut et repellendus quia optio dicta.", "Product 5", "M", "Footwear" },
                    { 6, new DateTime(2020, 8, 14, 10, 38, 57, 583, DateTimeKind.Local).AddTicks(1069), "InStock", "Eius quia et libero odio harum est quidem. Tempore enim quasi esse repellat reprehenderit vel aut suscipit. Iusto totam sapiente iste. Ipsa officiis saepe qui reprehenderit quam veniam natus. Unde ut nemo rerum deserunt commodi omnis.", "Product 6", "S", "Underwear" },
                    { 7, new DateTime(2020, 8, 23, 10, 38, 57, 583, DateTimeKind.Local).AddTicks(8846), "OutStock", "Quasi esse debitis sit culpa dolorem cum minima. Repellendus delectus perspiciatis cumque omnis inventore. At dolor fugiat itaque qui possimus. Repudiandae id consequatur officia est. Commodi fugiat quia consequuntur molestiae non exercitationem sunt ipsa.", "Product 7", "L", "Underwear" },
                    { 8, new DateTime(2020, 8, 15, 10, 38, 57, 584, DateTimeKind.Local).AddTicks(7812), "OutStock", "Officiis in quidem exercitationem quas temporibus ut. Minus corrupti molestiae veniam et doloremque qui non enim. Delectus impedit nulla non maiores occaecati minima quis. Cum incidunt at voluptates voluptas doloribus et porro odio. Ut voluptatem aut ad qui blanditiis illum.", "Product 8", "L", "Accessory" },
                    { 9, new DateTime(2020, 8, 17, 10, 38, 57, 585, DateTimeKind.Local).AddTicks(3792), "InStock", "In odio eum quod quod dignissimos commodi est. Vel deserunt quia dolorem quia. Cum dolorum praesentium ut. Illo sit velit pariatur sunt voluptates voluptas et nam.", "Product 9", "L", "Footwear" },
                    { 10, new DateTime(2020, 7, 16, 10, 38, 57, 586, DateTimeKind.Local).AddTicks(32), "OutStock", "Officiis ab et voluptate voluptates. Sit qui ipsam voluptas consectetur dolorum. Dolorem non recusandae explicabo consequatur dolor atque fuga. Explicabo et voluptatem culpa. Vero et sint praesentium.", "Product 10", "M", "Accessory" },
                    { 11, new DateTime(2020, 8, 4, 10, 38, 57, 586, DateTimeKind.Local).AddTicks(7432), "InStock", "Sint est alias nobis necessitatibus illo delectus debitis. Doloremque aut ad est eaque. Consequatur voluptates ut aspernatur sunt exercitationem sequi qui et. Dicta assumenda et necessitatibus. Sunt dicta expedita maiores dolor.", "Product 11", "S", "Outerwear" },
                    { 12, new DateTime(2020, 8, 18, 10, 38, 57, 587, DateTimeKind.Local).AddTicks(4027), "InStock", "Commodi beatae quos rerum ea voluptas quidem. Voluptatem eius tempora aut. Minus ut praesentium dolores omnis quia. Et recusandae voluptatem voluptas suscipit blanditiis aut. Optio voluptatem temporibus temporibus.", "Product 12", "M", "Footwear" },
                    { 13, new DateTime(2020, 8, 19, 10, 38, 57, 587, DateTimeKind.Local).AddTicks(9439), "InStock", "Non earum aspernatur quaerat nihil et commodi doloribus consequatur. Voluptatibus quod eos quod vel autem. Aut omnis aut consequatur deserunt maiores veritatis reiciendis.", "Product 13", "S", "Outerwear" },
                    { 14, new DateTime(2020, 6, 24, 10, 38, 57, 588, DateTimeKind.Local).AddTicks(7515), "OutStock", "Nemo non est soluta facilis perspiciatis dolores optio. Veniam dolor incidunt non. Et et animi enim libero numquam aut suscipit inventore. Omnis nulla facere at. Sed deleniti consequuntur ipsum aspernatur atque.", "Product 14", "M", "Accessory" },
                    { 15, new DateTime(2020, 7, 9, 10, 38, 57, 589, DateTimeKind.Local).AddTicks(3117), "InStock", "Eum dolorum ipsum aut ut corrupti. Quia debitis mollitia officiis blanditiis reiciendis recusandae officiis. Qui a qui natus aut est.", "Product 15", "L", "Outerwear" },
                    { 16, new DateTime(2020, 8, 31, 10, 38, 57, 589, DateTimeKind.Local).AddTicks(7028), "InStock", "Aspernatur nostrum eveniet hic. Aspernatur qui eos et voluptatem eum. Optio esse molestias labore.", "Product 16", "S", "Outerwear" },
                    { 17, new DateTime(2020, 6, 13, 10, 38, 57, 590, DateTimeKind.Local).AddTicks(2092), "InStock", "Earum amet omnis est placeat ab numquam distinctio quisquam. Nostrum ipsam distinctio ut numquam iure. Ullam sunt aut labore.", "Product 17", "S", "Underwear" },
                    { 18, new DateTime(2020, 6, 16, 10, 38, 57, 590, DateTimeKind.Local).AddTicks(6943), "InStock", "Vel incidunt voluptatem iste alias pariatur. Consequatur excepturi eos voluptatem minus et. Natus quia molestiae voluptatum mollitia nihil.", "Product 18", "S", "Footwear" },
                    { 19, new DateTime(2020, 6, 19, 10, 38, 57, 591, DateTimeKind.Local).AddTicks(3438), "InStock", "Dolores assumenda dolor cum repudiandae velit corporis vero et. Et ut voluptates labore ducimus hic magni temporibus dolores. Dolorum quod corrupti iusto ex occaecati rem.", "Product 19", "XS", "Accessory" },
                    { 20, new DateTime(2020, 7, 24, 10, 38, 57, 592, DateTimeKind.Local).AddTicks(181), "InStock", "Fugiat omnis hic voluptas et. In voluptates perferendis qui tenetur et optio ipsum. Unde consequatur voluptatum qui sequi. Voluptate culpa fuga odit perspiciatis pariatur aut fuga.", "Product 20", "S", "Outerwear" },
                    { 21, new DateTime(2020, 8, 14, 10, 38, 57, 592, DateTimeKind.Local).AddTicks(5211), "OutStock", "Ullam expedita voluptas vel odit. Saepe fugit velit omnis. Voluptas est sed et consequatur ab inventore vel aut.", "Product 21", "XS", "Underwear" },
                    { 22, new DateTime(2020, 8, 6, 10, 38, 57, 593, DateTimeKind.Local).AddTicks(574), "OutStock", "Repellendus unde dolorum perspiciatis qui doloribus. Ut odio nisi et enim. Ab eos quia atque molestiae ad et cumque quo.", "Product 22", "XS", "Footwear" },
                    { 23, new DateTime(2020, 6, 16, 10, 38, 57, 593, DateTimeKind.Local).AddTicks(5637), "InStock", "Esse et explicabo rerum ut. Et sapiente doloremque consequatur fuga tempore autem. In incidunt perferendis et aspernatur accusamus eligendi.", "Product 23", "L", "Accessory" },
                    { 24, new DateTime(2020, 8, 11, 10, 38, 57, 594, DateTimeKind.Local).AddTicks(2624), "OutStock", "Et ad dolor culpa corrupti. Sit maiores ea quia sunt vitae iure perspiciatis. Eos quidem aliquam sequi aut nesciunt officiis quasi. Expedita velit laudantium non non eos.", "Product 24", "M", "Footwear" },
                    { 25, new DateTime(2020, 9, 17, 10, 38, 57, 594, DateTimeKind.Local).AddTicks(8258), "InStock", "Maiores soluta consequatur tempore expedita minus id. Ut dolor porro dolorem quo rem quos autem et. Suscipit molestiae quaerat fugiat.", "Product 25", "M", "Footwear" },
                    { 26, new DateTime(2020, 6, 21, 10, 38, 57, 595, DateTimeKind.Local).AddTicks(3998), "InStock", "Velit libero repellat alias odit. Voluptas et dolor eum tempora ab nulla rerum odit. Ea commodi rerum doloribus enim molestias nostrum ipsa.", "Product 26", "L", "Outerwear" },
                    { 27, new DateTime(2020, 9, 7, 10, 38, 57, 595, DateTimeKind.Local).AddTicks(9668), "OutStock", "Sed ea consequatur dolore. Corporis nesciunt sunt et eos soluta non. Architecto error nostrum deleniti eius ex. Recusandae in quasi corporis expedita.", "Product 27", "M", "Footwear" },
                    { 28, new DateTime(2020, 8, 5, 10, 38, 57, 596, DateTimeKind.Local).AddTicks(8905), "OutStock", "Illo ab impedit omnis nihil repudiandae corporis tempore quae. Voluptas alias ipsam asperiores est et et enim. Aut at adipisci consequatur voluptatem nihil laboriosam. Alias quae quaerat aut libero. Minus dolores repellat officia culpa sequi harum.", "Product 28", "XS", "Outerwear" },
                    { 30, new DateTime(2020, 8, 17, 10, 38, 57, 598, DateTimeKind.Local).AddTicks(1696), "InStock", "Expedita sequi sit necessitatibus soluta tempora commodi. Illo corrupti sit facere delectus repudiandae reprehenderit quasi. In laboriosam et dolor natus ut aut sit. Culpa ratione voluptas consequatur neque.", "Product 30", "L", "Outerwear" },
                    { 61, new DateTime(2020, 8, 25, 10, 38, 57, 617, DateTimeKind.Local).AddTicks(9651), "OutStock", "Ab et qui est. Sint in corporis non sapiente quo ducimus quia incidunt. Reiciendis qui facere aliquid id. Voluptas iusto eos consequatur.", "Product 61", "S", "Accessory" },
                    { 62, new DateTime(2020, 6, 30, 10, 38, 57, 618, DateTimeKind.Local).AddTicks(3599), "OutStock", "Temporibus a cum alias. Unde qui porro ut. Velit quia exercitationem quia odit voluptatibus.", "Product 62", "L", "Footwear" },
                    { 63, new DateTime(2020, 7, 25, 10, 38, 57, 619, DateTimeKind.Local).AddTicks(2699), "InStock", "Similique cum voluptatum tenetur. Sunt magni aut molestiae adipisci atque esse sint. Rem sint voluptas et repudiandae id. Consequatur atque nihil excepturi quos ipsum id inventore sit. Quis facere ex autem in animi veritatis beatae rem.", "Product 63", "S", "Footwear" },
                    { 96, new DateTime(2020, 9, 18, 10, 38, 57, 643, DateTimeKind.Local).AddTicks(5320), "InStock", "Molestias ea eum aut ex. Minima temporibus aut reprehenderit magnam ullam cum reiciendis accusamus. Atque ab quia et.", "Product 96", "L", "Underwear" },
                    { 97, new DateTime(2020, 6, 20, 10, 38, 57, 644, DateTimeKind.Local).AddTicks(3852), "InStock", "Soluta eligendi saepe ea enim autem quasi autem sed. Perspiciatis eligendi hic enim voluptate quia. Est laboriosam iusto reprehenderit voluptatem numquam in. Ex expedita eveniet a et. Vero fugiat est quas ut quam error.", "Product 97", "L", "Footwear" },
                    { 98, new DateTime(2020, 9, 7, 10, 38, 57, 644, DateTimeKind.Local).AddTicks(9939), "OutStock", "In corporis ut et quia eveniet velit. Aut nisi nihil culpa laboriosam rerum. Alias ipsum sunt voluptatum. Sunt dolores accusantium modi qui beatae.", "Product 98", "M", "Outerwear" },
                    { 99, new DateTime(2020, 6, 27, 10, 38, 57, 645, DateTimeKind.Local).AddTicks(7951), "InStock", "Aut temporibus ut assumenda. Esse quia eos voluptatem ipsa labore illum doloribus. Voluptatem porro dolor suscipit vitae quaerat. Quod voluptatibus similique rerum non dolor optio. Id necessitatibus consequuntur laudantium rerum sint.", "Product 99", "M", "Accessory" },
                    { 100, new DateTime(2020, 8, 11, 10, 38, 57, 646, DateTimeKind.Local).AddTicks(3478), "OutStock", "Aut illum possimus quo. Aliquam necessitatibus sint perspiciatis ullam eveniet beatae nemo. Voluptate voluptatem itaque enim fuga at similique eveniet vitae.", "Product 100", "S", "Outerwear" },
                    { 101, new DateTime(2020, 7, 3, 10, 38, 57, 647, DateTimeKind.Local).AddTicks(1113), "InStock", "Voluptates qui et expedita eos laborum nisi. Accusamus non expedita quos eum est voluptatem veniam. Perspiciatis ducimus rerum ut soluta consequuntur. Ea quidem fugit qui et sed ut placeat est.", "Product 101", "S", "Accessory" },
                    { 102, new DateTime(2020, 7, 18, 10, 38, 57, 647, DateTimeKind.Local).AddTicks(5673), "InStock", "Laudantium magni maiores consequuntur. Numquam et excepturi quis. Dolor necessitatibus nisi distinctio dolores. Est itaque labore et.", "Product 102", "L", "Underwear" },
                    { 103, new DateTime(2020, 8, 30, 10, 38, 57, 648, DateTimeKind.Local).AddTicks(3038), "InStock", "Quae amet saepe labore excepturi animi dolorum tempora. Libero delectus repellendus explicabo. Consequatur impedit aut repellat laudantium sit labore qui cum. Quo consequuntur rerum earum eos eos repudiandae provident.", "Product 103", "M", "Underwear" },
                    { 104, new DateTime(2020, 8, 19, 10, 38, 57, 648, DateTimeKind.Local).AddTicks(9102), "OutStock", "Voluptas neque iure sed. Voluptates sunt provident rerum. Dolor aliquam laudantium enim. Omnis quia delectus totam quisquam. Magni officia consequuntur perspiciatis adipisci culpa.", "Product 104", "L", "Accessory" },
                    { 105, new DateTime(2020, 6, 21, 10, 38, 57, 649, DateTimeKind.Local).AddTicks(5084), "InStock", "Perspiciatis esse dolore quos rerum. Dolorum praesentium facere commodi est. Quam hic cumque quibusdam ipsam beatae incidunt repellendus. Omnis vero nemo voluptatem modi.", "Product 105", "XS", "Underwear" },
                    { 106, new DateTime(2020, 7, 4, 10, 38, 57, 650, DateTimeKind.Local).AddTicks(4124), "InStock", "Doloribus harum hic qui. Saepe iusto fuga vitae itaque quidem ducimus expedita quisquam. Itaque qui praesentium sequi dolores eum assumenda. Nisi aliquid delectus nemo iure dicta ut. Aliquam laboriosam provident officia quo aut explicabo rerum aut.", "Product 106", "S", "Underwear" },
                    { 107, new DateTime(2020, 8, 2, 10, 38, 57, 651, DateTimeKind.Local).AddTicks(4280), "OutStock", "Ipsum quasi sit eligendi temporibus rerum aut ea dolor. Voluptas quia deleniti beatae voluptatem placeat quisquam rem saepe. Velit laboriosam qui ea ipsa est. Eaque et quia minus dolorem et quos accusamus beatae. Maxime modi nisi vel et ullam enim similique.", "Product 107", "XS", "Outerwear" },
                    { 108, new DateTime(2020, 6, 24, 10, 38, 57, 652, DateTimeKind.Local).AddTicks(2906), "InStock", "Quaerat aut ipsum ea reiciendis expedita qui. Eos molestiae optio ipsam optio. At enim consequuntur impedit. Ut temporibus fugit cupiditate ab corporis incidunt sed nobis. Facilis totam vel est velit neque delectus qui molestiae.", "Product 108", "L", "Underwear" },
                    { 109, new DateTime(2020, 7, 8, 10, 38, 57, 652, DateTimeKind.Local).AddTicks(7925), "OutStock", "Aliquid quo consequatur officiis minima qui rerum. Nihil nihil itaque quod earum et. Maxime et consequuntur commodi sunt odio.", "Product 109", "L", "Underwear" },
                    { 110, new DateTime(2020, 7, 12, 10, 38, 57, 653, DateTimeKind.Local).AddTicks(6344), "OutStock", "Praesentium vel blanditiis a sunt neque eos. Dolore optio officiis voluptas aut sed quaerat quos sunt. Quaerat autem placeat quae ab. Commodi corporis est suscipit adipisci. Quisquam sit porro voluptas culpa consectetur quaerat.", "Product 110", "XS", "Underwear" },
                    { 111, new DateTime(2020, 7, 16, 10, 38, 57, 654, DateTimeKind.Local).AddTicks(6273), "OutStock", "Voluptatum ut et sed sed quis. Explicabo hic accusantium ut soluta autem sit quia ut. Eligendi sapiente maiores nulla voluptatem sit. Quia ipsum dolore molestias ut facere labore quos quia. Occaecati sunt et et perspiciatis est velit commodi.", "Product 111", "M", "Underwear" },
                    { 112, new DateTime(2020, 7, 16, 10, 38, 57, 655, DateTimeKind.Local).AddTicks(5440), "OutStock", "Earum a possimus minus molestiae dolorum explicabo officiis. Molestiae aut laborum quis facilis quisquam deleniti dolorem. Porro occaecati aut rerum. Est in non laborum qui debitis ut impedit. Qui explicabo ducimus asperiores rem eum atque mollitia.", "Product 112", "S", "Underwear" },
                    { 113, new DateTime(2020, 7, 30, 10, 38, 57, 656, DateTimeKind.Local).AddTicks(1433), "OutStock", "Minima et consequuntur eum ex esse quia omnis nisi. Impedit in molestiae temporibus nam repellendus ut atque qui. Neque autem consectetur corporis earum.", "Product 113", "XS", "Underwear" },
                    { 114, new DateTime(2020, 7, 1, 10, 38, 57, 656, DateTimeKind.Local).AddTicks(7005), "OutStock", "Officiis consequuntur molestias omnis sed sit fugiat laborum. Voluptatem officia voluptas ut nam dolores. Nesciunt explicabo nesciunt dolor nostrum cumque provident.", "Product 114", "M", "Accessory" },
                    { 115, new DateTime(2020, 9, 5, 10, 38, 57, 657, DateTimeKind.Local).AddTicks(1066), "OutStock", "Molestiae eum sapiente est et. Perspiciatis nulla enim quisquam veritatis. Et impedit est et ad.", "Product 115", "L", "Underwear" },
                    { 116, new DateTime(2020, 7, 28, 10, 38, 57, 657, DateTimeKind.Local).AddTicks(9194), "OutStock", "Praesentium enim fugiat laudantium quidem sit. Soluta amet rerum pariatur facilis. Temporibus voluptatibus repudiandae amet sed quisquam sit odit. Hic et voluptatem nemo optio non repudiandae. Ipsum alias itaque ex et.", "Product 116", "L", "Footwear" },
                    { 117, new DateTime(2020, 8, 10, 10, 38, 57, 658, DateTimeKind.Local).AddTicks(5224), "OutStock", "Et nostrum in alias qui enim. Ipsum velit blanditiis eligendi et minima aliquam et cumque. Error est minima impedit adipisci assumenda velit qui.", "Product 117", "L", "Footwear" },
                    { 118, new DateTime(2020, 8, 15, 10, 38, 57, 658, DateTimeKind.Local).AddTicks(9227), "OutStock", "Molestiae deleniti nihil est non. Rerum quo laboriosam quae. Perferendis voluptas ut blanditiis necessitatibus aut.", "Product 118", "L", "Underwear" },
                    { 119, new DateTime(2020, 7, 1, 10, 38, 57, 659, DateTimeKind.Local).AddTicks(7461), "OutStock", "Velit qui distinctio dolores officiis. Corporis dolores sed voluptatem in eaque dolores. Quia labore voluptate facilis. Perspiciatis facere dolores doloremque id et nam voluptates cupiditate. Est porro sunt a fugit id distinctio.", "Product 119", "S", "Outerwear" },
                    { 120, new DateTime(2020, 7, 24, 10, 38, 57, 660, DateTimeKind.Local).AddTicks(3410), "InStock", "Eaque ut quas voluptatem. Rerum et labore explicabo ex. Impedit voluptatem maxime aliquid sint doloremque voluptatem et voluptate. Asperiores sit corporis maiores.", "Product 120", "S", "Underwear" },
                    { 121, new DateTime(2020, 6, 27, 10, 38, 57, 660, DateTimeKind.Local).AddTicks(9643), "OutStock", "Qui earum inventore porro. Et distinctio cupiditate consequuntur doloribus omnis sunt. Quaerat aut et assumenda. Voluptatem laboriosam dignissimos natus sit et ex qui et.", "Product 121", "M", "Accessory" },
                    { 122, new DateTime(2020, 8, 5, 10, 38, 57, 661, DateTimeKind.Local).AddTicks(6304), "InStock", "Libero neque quaerat minima ut qui optio et quae. Laborum corporis sunt eaque possimus soluta saepe nam optio. Nemo et in voluptatem dolor molestias cumque nesciunt.", "Product 122", "S", "Accessory" },
                    { 95, new DateTime(2020, 7, 12, 10, 38, 57, 643, DateTimeKind.Local).AddTicks(353), "InStock", "Recusandae veritatis itaque earum adipisci et repellendus commodi. Quis dolores architecto ullam. Voluptatem iure numquam explicabo sit molestiae. Et dignissimos est officiis ratione eum nemo cum modi.", "Product 95", "L", "Accessory" },
                    { 94, new DateTime(2020, 7, 12, 10, 38, 57, 642, DateTimeKind.Local).AddTicks(388), "OutStock", "Ipsam dolorem quis quo. Exercitationem et doloremque ut necessitatibus nostrum. Qui autem officiis et a. Tempora saepe enim veritatis placeat voluptatem iure laudantium. Qui placeat ullam ut voluptatem.", "Product 94", "S", "Footwear" },
                    { 93, new DateTime(2020, 8, 27, 10, 38, 57, 640, DateTimeKind.Local).AddTicks(8758), "InStock", "Magni in ex perferendis fuga quisquam. Beatae optio placeat ad error deleniti dolores aut facere. Reprehenderit quia accusamus rerum pariatur commodi molestiae est id. Qui et iure provident.", "Product 93", "L", "Underwear" },
                    { 92, new DateTime(2020, 7, 11, 10, 38, 57, 640, DateTimeKind.Local).AddTicks(1319), "OutStock", "Ullam voluptatem amet quo neque atque. Aut laborum molestias doloribus qui. Nobis rerum voluptatem repudiandae nulla cumque consectetur eum.", "Product 92", "L", "Footwear" },
                    { 64, new DateTime(2020, 6, 12, 10, 38, 57, 620, DateTimeKind.Local).AddTicks(1907), "OutStock", "A qui sit in et sequi ut. Aut ullam dolor enim. Illo quod ducimus ipsa est aut recusandae voluptatem nobis. Fugit aliquid ipsam soluta et culpa est. Eum repellat mollitia eum aut recusandae ipsa temporibus ipsum.", "Product 64", "M", "Accessory" },
                    { 65, new DateTime(2020, 6, 27, 10, 38, 57, 620, DateTimeKind.Local).AddTicks(8354), "InStock", "Officia tempora et quidem quos. Modi nobis aliquam sunt maiores aliquam. Et eius quia sint voluptas minima. Modi aut maxime et esse quam sunt excepturi.", "Product 65", "L", "Underwear" },
                    { 66, new DateTime(2020, 7, 9, 10, 38, 57, 621, DateTimeKind.Local).AddTicks(7711), "OutStock", "Quidem laborum non nesciunt deleniti assumenda incidunt. Earum omnis magnam delectus labore atque. Officiis est a sit tempora reiciendis incidunt. Nisi odio sunt est quaerat quaerat est dolorem et. Et rerum sit eaque veniam quia quaerat laboriosam.", "Product 66", "XS", "Accessory" },
                    { 67, new DateTime(2020, 7, 17, 10, 38, 57, 622, DateTimeKind.Local).AddTicks(5603), "OutStock", "Facere enim minus libero suscipit. Enim autem aut molestias rerum qui et delectus minus. Quia fuga repellat veniam sunt eos. Facilis adipisci magni amet nemo. Doloremque natus pariatur officia nostrum.", "Product 67", "M", "Footwear" },
                    { 68, new DateTime(2020, 8, 28, 10, 38, 57, 623, DateTimeKind.Local).AddTicks(5037), "InStock", "Sed odio tempore commodi eum ut qui aut rerum. A quia non delectus consequatur voluptatem in dolor aut. Modi molestias consectetur vero. Incidunt nulla ad voluptas eaque et molestias. Ea temporibus aut adipisci omnis sequi sint nobis.", "Product 68", "L", "Footwear" },
                    { 69, new DateTime(2020, 8, 29, 10, 38, 57, 624, DateTimeKind.Local).AddTicks(929), "OutStock", "Sunt officiis repellat delectus vel voluptas ut hic. Sint explicabo et ad rerum quia dignissimos. Ipsum quia aut error sed facilis ratione.", "Product 69", "S", "Accessory" },
                    { 70, new DateTime(2020, 7, 9, 10, 38, 57, 624, DateTimeKind.Local).AddTicks(8271), "InStock", "Ducimus impedit magnam nostrum quas et sunt eaque amet. Fugiat optio atque esse. Assumenda eum nostrum esse deserunt itaque cum sapiente. Dolores rerum porro ut esse velit.", "Product 70", "L", "Outerwear" },
                    { 71, new DateTime(2020, 7, 13, 10, 38, 57, 625, DateTimeKind.Local).AddTicks(3570), "OutStock", "Quos enim nihil delectus perferendis minima voluptas tenetur sed. Quis omnis quas ipsa. Consequuntur libero doloremque tenetur qui qui porro.", "Product 71", "XS", "Accessory" },
                    { 72, new DateTime(2020, 8, 13, 10, 38, 57, 625, DateTimeKind.Local).AddTicks(9864), "InStock", "Ipsa rerum quia error vero autem non ratione nulla. Quae aut veritatis veniam explicabo et. Ut qui quasi nam dignissimos quod dolor blanditiis enim.", "Product 72", "XS", "Underwear" },
                    { 73, new DateTime(2020, 9, 12, 10, 38, 57, 626, DateTimeKind.Local).AddTicks(6566), "InStock", "Repellat molestiae et perferendis officia quas quo molestias hic. Laudantium nihil cupiditate nisi architecto ut quibusdam. Optio quia vel nostrum aut. Occaecati sapiente sit repellat.", "Product 73", "S", "Underwear" },
                    { 74, new DateTime(2020, 6, 13, 10, 38, 57, 627, DateTimeKind.Local).AddTicks(4115), "OutStock", "Aliquid maxime quo totam. Harum reiciendis mollitia aut quo ad id sed at. Reprehenderit consectetur dolorum unde sunt sit tempora nesciunt. Eos quo vitae saepe eos voluptas autem.", "Product 74", "XS", "Underwear" },
                    { 75, new DateTime(2020, 7, 6, 10, 38, 57, 628, DateTimeKind.Local).AddTicks(660), "OutStock", "Sit aut expedita eius est distinctio ad hic. Autem voluptatem numquam dicta perferendis qui vel sit. Ex quis eum ut enim. Est corrupti quas molestiae.", "Product 75", "S", "Underwear" },
                    { 76, new DateTime(2020, 6, 22, 10, 38, 57, 628, DateTimeKind.Local).AddTicks(6259), "OutStock", "Dolor ipsa sit dolores qui expedita excepturi. Quia accusantium ut suscipit repellendus. Ut est expedita earum natus. Aut molestiae sint temporibus.", "Product 76", "S", "Footwear" },
                    { 124, new DateTime(2020, 7, 31, 10, 38, 57, 662, DateTimeKind.Local).AddTicks(7169), "InStock", "Fuga rerum nesciunt distinctio deserunt. Sint et dignissimos aut alias harum nobis quae. Et vitae atque eaque et officia qui.", "Product 124", "M", "Outerwear" },
                    { 77, new DateTime(2020, 8, 18, 10, 38, 57, 629, DateTimeKind.Local).AddTicks(3385), "OutStock", "Provident accusamus repellendus aliquam. Tempora laborum repudiandae voluptates et ut et. Recusandae voluptatem illum deleniti asperiores exercitationem amet. Amet illo vel est. Dolor itaque odit sint modi.", "Product 77", "XS", "Footwear" },
                    { 79, new DateTime(2020, 8, 22, 10, 38, 57, 631, DateTimeKind.Local).AddTicks(129), "InStock", "Quia error quidem explicabo voluptatem enim iste inventore. Commodi et et cumque nulla repellendus deserunt hic rerum. Rerum voluptatem aperiam a magnam. Quia sit eius reprehenderit fugiat. Enim natus sed doloribus eaque ut facere.", "Product 79", "L", "Footwear" },
                    { 80, new DateTime(2020, 7, 22, 10, 38, 57, 631, DateTimeKind.Local).AddTicks(6204), "OutStock", "Quas delectus pariatur et et omnis rerum dolore minima. Minima aut molestiae rerum qui rerum. Voluptates eius ullam aspernatur eligendi iste et ipsam.", "Product 80", "M", "Underwear" },
                    { 81, new DateTime(2020, 9, 13, 10, 38, 57, 632, DateTimeKind.Local).AddTicks(5683), "InStock", "Molestias quis blanditiis tempora autem ut voluptatum quia quo. Quia qui enim harum quis. Quas repudiandae at voluptatem nostrum qui architecto est necessitatibus. Voluptatem fugiat harum nulla numquam sit esse distinctio dolores. Consequatur nesciunt nisi harum eum.", "Product 81", "S", "Accessory" },
                    { 82, new DateTime(2020, 7, 10, 10, 38, 57, 633, DateTimeKind.Local).AddTicks(4665), "InStock", "Ipsum numquam repellat aperiam corporis eos. Est ad est sed temporibus. Totam velit est libero exercitationem molestias vel. Temporibus suscipit error distinctio minus quas temporibus distinctio. Ut veniam aut quidem consequuntur sit fugiat sed enim.", "Product 82", "L", "Footwear" },
                    { 83, new DateTime(2020, 8, 8, 10, 38, 57, 634, DateTimeKind.Local).AddTicks(1954), "OutStock", "Hic nemo et minus debitis ad impedit eos non. In quod est aut est. Sit iusto doloribus dignissimos. Officiis laudantium quibusdam qui earum nihil. Illo iure ducimus et.", "Product 83", "S", "Outerwear" },
                    { 84, new DateTime(2020, 8, 29, 10, 38, 57, 634, DateTimeKind.Local).AddTicks(9045), "InStock", "Temporibus architecto quidem cumque saepe culpa sit est adipisci. Nemo voluptas veniam qui. Temporibus expedita sit vero dolorum impedit voluptatem voluptates. Quia ea molestiae nesciunt recusandae aut.", "Product 84", "S", "Accessory" },
                    { 85, new DateTime(2020, 8, 30, 10, 38, 57, 635, DateTimeKind.Local).AddTicks(4179), "InStock", "Nisi nesciunt doloremque eos rerum amet. Voluptatem laboriosam assumenda cupiditate reprehenderit iste. Ut error nesciunt iure blanditiis enim qui.", "Product 85", "M", "Accessory" },
                    { 86, new DateTime(2020, 8, 23, 10, 38, 57, 636, DateTimeKind.Local).AddTicks(1669), "InStock", "Aut itaque aut ipsa officiis iste laborum molestias. Corporis commodi ut libero corrupti veniam. Laboriosam molestias non repellendus sed. Quo repudiandae velit qui. Quibusdam illo et aut dignissimos sit.", "Product 86", "XS", "Underwear" },
                    { 87, new DateTime(2020, 6, 23, 10, 38, 57, 636, DateTimeKind.Local).AddTicks(8828), "OutStock", "Quos modi dolore cum dolorem ipsum sequi quis occaecati. Quaerat sint officiis saepe. Aut id nihil neque ut corrupti consectetur beatae cumque. A debitis excepturi totam et sit.", "Product 87", "M", "Accessory" },
                    { 88, new DateTime(2020, 8, 30, 10, 38, 57, 637, DateTimeKind.Local).AddTicks(9308), "InStock", "Debitis quas ipsam et doloremque itaque aut incidunt necessitatibus. Reprehenderit ipsam qui praesentium excepturi eius ratione unde. Minus beatae voluptate beatae est voluptatem voluptatem consequuntur inventore. Eum commodi nemo inventore repellat. Rerum perferendis amet inventore aperiam labore v", "Product 88", "L", "Outerwear" },
                    { 89, new DateTime(2020, 7, 29, 10, 38, 57, 638, DateTimeKind.Local).AddTicks(4378), "InStock", "Vero voluptates autem suscipit aut velit. Et amet dolores velit. Repudiandae molestiae repellendus temporibus eos dolorem voluptatum qui et.", "Product 89", "M", "Underwear" },
                    { 90, new DateTime(2020, 7, 11, 10, 38, 57, 638, DateTimeKind.Local).AddTicks(9899), "OutStock", "Sunt et corrupti assumenda officiis facilis eum. Earum id expedita provident iure ullam. Nesciunt reprehenderit deleniti sequi. Voluptatem error et perferendis.", "Product 90", "M", "Footwear" },
                    { 91, new DateTime(2020, 9, 11, 10, 38, 57, 639, DateTimeKind.Local).AddTicks(6218), "OutStock", "Qui rerum quaerat deleniti quas aut. Nostrum placeat qui mollitia optio sed quia officia reiciendis. Blanditiis ab exercitationem eos qui maxime doloremque odit aut.", "Product 91", "L", "Underwear" },
                    { 78, new DateTime(2020, 8, 23, 10, 38, 57, 630, DateTimeKind.Local).AddTicks(1497), "OutStock", "Qui est sit cum accusantium sequi amet suscipit. Maiores eligendi et voluptatibus dolore ducimus quasi ut. Et hic corporis ab laboriosam. Officiis ut aliquam repudiandae qui est est placeat provident.", "Product 78", "S", "Outerwear" },
                    { 249, new DateTime(2020, 8, 27, 10, 38, 57, 821, DateTimeKind.Local).AddTicks(7008), "OutStock", "Voluptatem sint pariatur perspiciatis animi optio et consectetur quae. Beatae delectus sunt aut aliquam qui aut. Facilis ratione placeat numquam aut laboriosam omnis pariatur dicta. Veritatis sunt ipsum aliquid eius sequi sunt. Illo qui deleniti et iusto expedita nemo.", "Product 249", "M", "Footwear" },
                    { 250, new DateTime(2020, 6, 25, 10, 38, 57, 822, DateTimeKind.Local).AddTicks(855), "OutStock", "Quod voluptatem praesentium nulla. Aliquid alias eaque officia voluptatibus natus hic. Voluptates magni omnis animi voluptatem magnam.", "Product 250", "M", "Accessory" },
                    { 251, new DateTime(2020, 8, 14, 10, 38, 57, 822, DateTimeKind.Local).AddTicks(7948), "OutStock", "Nesciunt dolor atque eum asperiores. Rerum et quasi odit minima modi sapiente eligendi non. Voluptatem sint nam ipsa ut ex. Nemo rerum consequatur molestias voluptas ut reprehenderit iste. Corrupti autem et praesentium consequatur mollitia sint.", "Product 251", "M", "Footwear" },
                    { 409, new DateTime(2020, 8, 22, 10, 38, 57, 901, DateTimeKind.Local).AddTicks(3295), "InStock", "Aut est rerum quas veritatis sit. Magnam quasi id iste quia natus. Commodi ipsum amet veritatis ut omnis. Beatae laboriosam aut accusamus.", "Product 409", "L", "Footwear" },
                    { 410, new DateTime(2020, 8, 7, 10, 38, 57, 901, DateTimeKind.Local).AddTicks(6580), "OutStock", "Consequatur quis rerum eum eos natus et perferendis. Dignissimos dolor excepturi voluptatem at laboriosam. Repudiandae ducimus qui quos error quam. Qui officiis autem consequatur eaque dolor error molestiae quo.", "Product 410", "M", "Underwear" },
                    { 411, new DateTime(2020, 7, 4, 10, 38, 57, 901, DateTimeKind.Local).AddTicks(9590), "InStock", "Provident architecto quo beatae quidem pariatur neque. Ut nostrum odio voluptas illum sunt eius. Aut totam animi unde. Fugit tempore officia laudantium officiis eum aperiam perferendis.", "Product 411", "L", "Accessory" },
                    { 412, new DateTime(2020, 7, 26, 10, 38, 57, 902, DateTimeKind.Local).AddTicks(3715), "OutStock", "Omnis libero est facere expedita. Alias asperiores ipsa minima odit sunt voluptatem omnis nesciunt. Deleniti veniam ducimus voluptas dolorem deserunt qui quidem provident. Porro illo quaerat quibusdam alias libero. At corporis et est illum quidem asperiores.", "Product 412", "L", "Outerwear" },
                    { 413, new DateTime(2020, 7, 8, 10, 38, 57, 902, DateTimeKind.Local).AddTicks(7281), "OutStock", "Itaque ducimus ducimus necessitatibus omnis animi amet. Sequi enim iure aut aspernatur nostrum. Ut quisquam similique accusantium autem cumque. Enim id ullam ut vel adipisci. Nisi iusto officia est nisi quia reiciendis cupiditate.", "Product 413", "M", "Accessory" },
                    { 414, new DateTime(2020, 7, 26, 10, 38, 57, 902, DateTimeKind.Local).AddTicks(9619), "InStock", "Qui aut tempore ut pariatur sunt. Et sed earum suscipit omnis mollitia eos. Quos sed amet autem error quis placeat. Dolor ducimus error in.", "Product 414", "M", "Footwear" },
                    { 415, new DateTime(2020, 7, 23, 10, 38, 57, 903, DateTimeKind.Local).AddTicks(2358), "InStock", "Magni nobis corporis rem repellendus ad. Ut nihil dolor earum necessitatibus. Quis quam vero quia sit architecto voluptas vero. Voluptatem numquam dolor non sit. Beatae est architecto quo.", "Product 415", "M", "Footwear" },
                    { 416, new DateTime(2020, 8, 19, 10, 38, 57, 903, DateTimeKind.Local).AddTicks(4335), "OutStock", "Ut saepe et ea facilis qui deserunt nisi maxime. Aut laborum et rerum veritatis laudantium. Eveniet sint explicabo placeat laboriosam.", "Product 416", "M", "Underwear" },
                    { 417, new DateTime(2020, 7, 16, 10, 38, 57, 903, DateTimeKind.Local).AddTicks(7410), "InStock", "Ut in facilis nemo vero nobis assumenda culpa. Enim iste ex harum velit corporis. Rem veniam voluptatem corrupti ipsum architecto velit enim. Sunt qui fugit amet labore velit rem. Necessitatibus consequuntur consequuntur quidem.", "Product 417", "M", "Underwear" },
                    { 418, new DateTime(2020, 9, 9, 10, 38, 57, 904, DateTimeKind.Local).AddTicks(368), "OutStock", "Est et id quis dignissimos alias aut eum sequi. Et et sit quia dolores quis. Numquam aspernatur eius eaque. Maxime dolore omnis quo est sed error et. Velit repellat delectus earum.", "Product 418", "L", "Outerwear" },
                    { 419, new DateTime(2020, 7, 14, 10, 38, 57, 904, DateTimeKind.Local).AddTicks(4771), "InStock", "Distinctio qui fuga sequi quia nesciunt officiis omnis. Enim eum autem soluta modi dolorem earum quasi et. Voluptas rerum commodi magnam tempore soluta magnam iure. Sunt culpa officiis sapiente et.", "Product 419", "XS", "Accessory" },
                    { 420, new DateTime(2020, 8, 4, 10, 38, 57, 904, DateTimeKind.Local).AddTicks(8473), "OutStock", "Fugiat et non aut error doloremque quia officia. Sit consequatur voluptas voluptatem excepturi possimus cumque aliquam nam. Non et mollitia maxime qui odit.", "Product 420", "M", "Outerwear" },
                    { 421, new DateTime(2020, 8, 9, 10, 38, 57, 905, DateTimeKind.Local).AddTicks(2154), "OutStock", "Eaque qui nihil laudantium iusto est sequi. Temporibus cupiditate eum est. Alias a earum omnis iste corrupti assumenda libero. Et iure esse sit eius.", "Product 421", "L", "Underwear" },
                    { 422, new DateTime(2020, 8, 18, 10, 38, 57, 905, DateTimeKind.Local).AddTicks(7644), "InStock", "Explicabo et nemo repudiandae et magnam sint est aut. Aspernatur incidunt quia id amet doloribus tempore est autem. Eveniet est velit neque eius et natus provident rerum. Sapiente aliquam ut eveniet. Et voluptas doloremque et praesentium corrupti magnam.", "Product 422", "S", "Underwear" },
                    { 423, new DateTime(2020, 8, 11, 10, 38, 57, 906, DateTimeKind.Local).AddTicks(3267), "OutStock", "Sequi consequatur nesciunt alias qui qui. Maxime est soluta cupiditate rerum. Dolor molestias accusamus dolores dolores in totam. Est et est rerum et repudiandae odio sequi non. Beatae aspernatur totam qui dolor eum recusandae.", "Product 423", "M", "Underwear" },
                    { 424, new DateTime(2020, 8, 24, 10, 38, 57, 906, DateTimeKind.Local).AddTicks(7124), "InStock", "Illum ipsum culpa mollitia placeat maxime qui. Laborum et pariatur eius dolorum. In fugit quia vitae. Deserunt distinctio modi sint sit nam corporis itaque.", "Product 424", "L", "Accessory" },
                    { 425, new DateTime(2020, 9, 11, 10, 38, 57, 907, DateTimeKind.Local).AddTicks(2359), "OutStock", "Corrupti atque accusantium eum rerum dolore sit beatae dolor. Quia quia voluptate aut nobis illo amet ut. Est molestias sed iusto commodi sunt quia aliquid. Dolor cupiditate omnis dignissimos fugiat aliquam ea ad.", "Product 425", "M", "Outerwear" },
                    { 426, new DateTime(2020, 8, 13, 10, 38, 57, 907, DateTimeKind.Local).AddTicks(8095), "OutStock", "Cum ut ipsum quia cumque sint mollitia nihil. Et harum aut qui nostrum dicta et. Hic quam fugit voluptatem officiis possimus ipsa officiis qui. Exercitationem laborum officia tempora ratione architecto reprehenderit. Soluta eius error officia hic.", "Product 426", "S", "Underwear" },
                    { 427, new DateTime(2020, 8, 14, 10, 38, 57, 908, DateTimeKind.Local).AddTicks(3252), "InStock", "Ut dolorem nobis natus totam amet. Quibusdam eius a odit quo deleniti in. Ex aperiam quis sit dolores blanditiis ab. Dolorem nihil incidunt sed laboriosam laboriosam sed. Nam ut nisi doloribus ullam.", "Product 427", "S", "Accessory" },
                    { 428, new DateTime(2020, 7, 29, 10, 38, 57, 908, DateTimeKind.Local).AddTicks(8213), "InStock", "Id sed porro et dolorum. Et pariatur recusandae minima labore. Non nesciunt qui minima distinctio aut numquam. Provident cum qui praesentium beatae et aliquid. Iusto culpa et ut nisi tenetur quia.", "Product 428", "L", "Footwear" },
                    { 429, new DateTime(2020, 9, 16, 10, 38, 57, 909, DateTimeKind.Local).AddTicks(3647), "InStock", "Accusantium eaque exercitationem voluptas voluptas voluptate modi quibusdam cum. Corrupti sequi dicta asperiores laudantium quos. Omnis et nisi voluptas harum vitae iste facere. Unde quidem accusantium sint itaque quia corrupti. Eos officiis tenetur eos.", "Product 429", "S", "Underwear" },
                    { 430, new DateTime(2020, 8, 2, 10, 38, 57, 909, DateTimeKind.Local).AddTicks(7570), "OutStock", "Ab magnam sed omnis est corporis. Iure expedita nobis aut voluptatem voluptatem. Aperiam natus eaque soluta aut neque. Necessitatibus voluptate maiores tenetur laborum soluta.", "Product 430", "XS", "Footwear" },
                    { 431, new DateTime(2020, 7, 19, 10, 38, 57, 910, DateTimeKind.Local).AddTicks(742), "InStock", "Ea ab veritatis non similique quia omnis vel officiis. Itaque qui aut esse maiores. Ea optio rerum deleniti consectetur.", "Product 431", "M", "Footwear" },
                    { 432, new DateTime(2020, 7, 11, 10, 38, 57, 910, DateTimeKind.Local).AddTicks(3916), "OutStock", "Est natus veritatis beatae eos in quasi placeat qui. Numquam tenetur distinctio qui dicta omnis. Provident et et illo.", "Product 432", "M", "Footwear" },
                    { 433, new DateTime(2020, 9, 7, 10, 38, 57, 910, DateTimeKind.Local).AddTicks(7438), "OutStock", "Et est eligendi et dolores veniam pariatur. Perferendis doloribus veritatis quis eveniet nulla explicabo. Aliquid occaecati consectetur et itaque harum perspiciatis.", "Product 433", "S", "Outerwear" },
                    { 434, new DateTime(2020, 9, 17, 10, 38, 57, 911, DateTimeKind.Local).AddTicks(2092), "OutStock", "Sed et consequatur rem. Alias ullam voluptatum alias molestias omnis quae sed omnis. Aliquam qui quam quis qui officiis rerum maiores. Maxime maiores sit velit ducimus unde similique autem.", "Product 434", "S", "Footwear" },
                    { 435, new DateTime(2020, 7, 5, 10, 38, 57, 911, DateTimeKind.Local).AddTicks(4756), "InStock", "Rem sapiente dolores accusamus enim. Eligendi aut dolorum mollitia rerum assumenda. Sit molestiae fuga enim dolores possimus. Eum impedit sit veniam. Quas voluptatibus autem beatae maxime.", "Product 435", "M", "Accessory" },
                    { 408, new DateTime(2020, 6, 23, 10, 38, 57, 901, DateTimeKind.Local).AddTicks(720), "InStock", "Earum et cumque quo voluptas eveniet voluptatem alias ipsum. Illum cumque quia nostrum fuga aut corrupti et. Qui et autem vel earum sit. Voluptate consequatur delectus dolorem voluptatibus enim et.", "Product 408", "S", "Footwear" },
                    { 436, new DateTime(2020, 7, 2, 10, 38, 57, 911, DateTimeKind.Local).AddTicks(6634), "OutStock", "Quidem iste facere quae. Sint facilis qui vero labore debitis. Odio cumque maxime ullam quibusdam et laboriosam odio.", "Product 436", "S", "Accessory" },
                    { 407, new DateTime(2020, 6, 17, 10, 38, 57, 900, DateTimeKind.Local).AddTicks(7255), "OutStock", "Odio sit odit distinctio nobis fugit et fugiat. Ut sed voluptates at quam. Nihil omnis quos maxime est reiciendis ut dolorem. Quia qui adipisci officia impedit qui tempora.", "Product 407", "S", "Accessory" },
                    { 405, new DateTime(2020, 8, 22, 10, 38, 57, 900, DateTimeKind.Local).AddTicks(294), "OutStock", "Doloremque unde velit sint ut quod sit sint. Ut et provident nostrum saepe. Consequatur placeat odio dolore dignissimos in porro.", "Product 405", "S", "Underwear" },
                    { 378, new DateTime(2020, 9, 7, 10, 38, 57, 889, DateTimeKind.Local).AddTicks(4834), "InStock", "Reiciendis similique illo doloribus aut. Praesentium nam facere voluptate qui. Modi ducimus ut omnis facere. Et distinctio quis vel quia omnis et labore. Veniam cum ea incidunt minus.", "Product 378", "M", "Outerwear" },
                    { 379, new DateTime(2020, 8, 10, 10, 38, 57, 889, DateTimeKind.Local).AddTicks(8325), "InStock", "Adipisci praesentium et soluta. Alias cupiditate et dolore soluta facere. Sint iure reiciendis exercitationem aut hic. Libero molestias consequatur libero consequuntur sit magni sunt.", "Product 379", "M", "Outerwear" },
                    { 380, new DateTime(2020, 7, 8, 10, 38, 57, 890, DateTimeKind.Local).AddTicks(3526), "InStock", "Veniam similique culpa earum esse praesentium enim reprehenderit harum. Et omnis et itaque voluptatem qui in. Doloribus aut qui nemo praesentium assumenda itaque. Dignissimos facilis aut repellendus distinctio.", "Product 380", "S", "Accessory" },
                    { 381, new DateTime(2020, 8, 12, 10, 38, 57, 890, DateTimeKind.Local).AddTicks(9253), "OutStock", "Aliquam rerum accusantium enim minima et sed. Modi cum aspernatur quia unde. Fugiat ut pariatur fuga. Aliquid dolore similique ad hic molestiae et.", "Product 381", "XS", "Outerwear" },
                    { 382, new DateTime(2020, 7, 18, 10, 38, 57, 891, DateTimeKind.Local).AddTicks(6516), "OutStock", "Ducimus quod et qui omnis omnis earum. Iusto consequatur corrupti dolores ducimus temporibus delectus sint natus. Voluptas et ut autem saepe vel accusantium amet. Ullam consequatur et optio ipsa enim.", "Product 382", "M", "Accessory" },
                    { 383, new DateTime(2020, 7, 25, 10, 38, 57, 892, DateTimeKind.Local).AddTicks(3019), "InStock", "Illum sequi sint animi eligendi qui. Velit qui tenetur et culpa. Ullam soluta sunt libero rerum aut et. Quod voluptatem adipisci id laborum beatae ab rerum et.", "Product 383", "M", "Outerwear" },
                    { 384, new DateTime(2020, 6, 20, 10, 38, 57, 892, DateTimeKind.Local).AddTicks(6965), "InStock", "Voluptatem aut qui ducimus fugiat et dolorem. Eius quas facilis enim. Quas impedit quis et.", "Product 384", "XS", "Footwear" },
                    { 385, new DateTime(2020, 7, 27, 10, 38, 57, 893, DateTimeKind.Local).AddTicks(1345), "InStock", "Recusandae ratione quaerat placeat qui qui odio et. Aliquid sint quisquam nihil. Optio aut qui excepturi accusamus.", "Product 385", "XS", "Underwear" },
                    { 386, new DateTime(2020, 6, 15, 10, 38, 57, 893, DateTimeKind.Local).AddTicks(4986), "InStock", "Eaque recusandae rerum atque. Repudiandae occaecati enim vitae blanditiis voluptatem. Illum excepturi quis eos.", "Product 386", "XS", "Accessory" },
                    { 387, new DateTime(2020, 8, 18, 10, 38, 57, 893, DateTimeKind.Local).AddTicks(9481), "OutStock", "Laudantium illo laborum fugit omnis consequuntur sint esse enim. Repellendus qui iste quia quo. Est velit necessitatibus voluptatum laborum. Minima architecto voluptates praesentium consequuntur sed ex quo ex. Officia ipsa laborum qui voluptatem at et.", "Product 387", "L", "Footwear" },
                    { 388, new DateTime(2020, 6, 14, 10, 38, 57, 894, DateTimeKind.Local).AddTicks(3213), "InStock", "Quas at nemo autem possimus ratione tempora quod ea. Quibusdam magni est et. Aliquam assumenda laudantium velit sapiente hic. Suscipit quasi dolores sit dolor. Ea asperiores aut quis occaecati voluptatem corporis sit eligendi.", "Product 388", "S", "Outerwear" },
                    { 389, new DateTime(2020, 6, 19, 10, 38, 57, 894, DateTimeKind.Local).AddTicks(5682), "InStock", "Tempore occaecati omnis amet iure in distinctio. Enim unde quia sit consequuntur rerum. Doloribus est ab quos. Voluptas rerum eius molestiae.", "Product 389", "M", "Outerwear" },
                    { 390, new DateTime(2020, 6, 16, 10, 38, 57, 894, DateTimeKind.Local).AddTicks(8871), "OutStock", "Magni maiores est laudantium sed animi est. Est tenetur consectetur veniam voluptate ab omnis rerum quis. A non rerum ex ducimus vero qui sint ducimus.", "Product 390", "L", "Accessory" },
                    { 391, new DateTime(2020, 7, 4, 10, 38, 57, 895, DateTimeKind.Local).AddTicks(2353), "OutStock", "Tempora quidem facilis totam exercitationem consequatur accusantium aliquid nisi. Nihil ut vel facere molestias et odit iure omnis. Recusandae qui sapiente ullam et alias ut soluta. At ipsum magnam nemo voluptas.", "Product 391", "L", "Outerwear" },
                    { 392, new DateTime(2020, 9, 11, 10, 38, 57, 895, DateTimeKind.Local).AddTicks(6990), "OutStock", "Dicta et et quia facilis excepturi et. Reprehenderit voluptate qui unde ea quia et corporis occaecati. Et autem a eveniet. Voluptatum eum atque ea architecto deleniti. Consectetur veritatis eum dignissimos placeat.", "Product 392", "S", "Accessory" },
                    { 393, new DateTime(2020, 6, 25, 10, 38, 57, 895, DateTimeKind.Local).AddTicks(9857), "OutStock", "Distinctio praesentium omnis aliquam. Placeat sunt voluptas reiciendis voluptas. Rerum mollitia nesciunt dolore labore consequatur nulla fugit.", "Product 393", "M", "Accessory" },
                    { 394, new DateTime(2020, 7, 25, 10, 38, 57, 896, DateTimeKind.Local).AddTicks(2891), "InStock", "Eveniet assumenda quod aut. Et quis accusamus qui aliquid. Voluptatem enim et voluptatem dicta magnam consequatur. Dolores aut architecto quo facilis. Molestiae qui in sapiente sit.", "Product 394", "S", "Footwear" },
                    { 395, new DateTime(2020, 6, 29, 10, 38, 57, 896, DateTimeKind.Local).AddTicks(6729), "InStock", "Adipisci pariatur in suscipit animi fugit et. Amet ab id reiciendis id. Blanditiis labore id sed officia enim quo iste repellendus. Numquam consequatur aperiam non occaecati ea doloremque. Quia assumenda et molestias mollitia et.", "Product 395", "M", "Underwear" },
                    { 396, new DateTime(2020, 7, 19, 10, 38, 57, 896, DateTimeKind.Local).AddTicks(9263), "OutStock", "Delectus inventore magni iusto veritatis asperiores sunt. Et quod totam impedit neque officiis. Libero quia dolorem sed explicabo enim deserunt quos.", "Product 396", "L", "Underwear" },
                    { 397, new DateTime(2020, 8, 30, 10, 38, 57, 897, DateTimeKind.Local).AddTicks(2234), "OutStock", "Officia eum quo harum. Deleniti provident eos vero totam iste. Vel sed iste fugiat accusamus incidunt illum totam. Perferendis inventore asperiores soluta est ut dolore dignissimos.", "Product 397", "M", "Outerwear" },
                    { 398, new DateTime(2020, 8, 25, 10, 38, 57, 897, DateTimeKind.Local).AddTicks(6416), "InStock", "Earum error hic et temporibus quis ut aut. A suscipit at cupiditate maiores odio deleniti sed. Alias tempora laboriosam earum nulla aut. Dolorem id porro non adipisci neque perferendis eligendi occaecati. Sequi vel optio numquam dolorum repellendus voluptate.", "Product 398", "XS", "Outerwear" },
                    { 399, new DateTime(2020, 9, 18, 10, 38, 57, 898, DateTimeKind.Local).AddTicks(492), "InStock", "Deserunt minus rerum iusto accusamus nesciunt vitae repellat. Quaerat et consectetur aut nihil. A qui et saepe nam ex provident explicabo. Possimus id labore voluptas omnis architecto. Esse hic omnis facere vitae et nulla aspernatur et.", "Product 399", "S", "Outerwear" },
                    { 400, new DateTime(2020, 8, 12, 10, 38, 57, 898, DateTimeKind.Local).AddTicks(3496), "InStock", "Quos voluptatum et et reiciendis ea temporibus rem. Ut tempore eos libero. Odio doloremque ipsa dignissimos corporis. Eos omnis aut harum. Et debitis architecto omnis id.", "Product 400", "XS", "Underwear" },
                    { 401, new DateTime(2020, 6, 14, 10, 38, 57, 898, DateTimeKind.Local).AddTicks(7309), "OutStock", "Et eligendi amet quos totam vel omnis qui. Ipsum soluta deserunt minus. Voluptate voluptas velit harum natus nam. Aut quis quo illo autem sed occaecati. Provident dicta ut est aut eaque consequuntur occaecati sunt.", "Product 401", "M", "Footwear" },
                    { 402, new DateTime(2020, 7, 23, 10, 38, 57, 898, DateTimeKind.Local).AddTicks(9942), "InStock", "Illum aut et iste unde dolore. Quas voluptatem sint provident. Ipsa et dolorem iure autem. Aut et consequatur culpa tempore id exercitationem.", "Product 402", "M", "Underwear" },
                    { 403, new DateTime(2020, 8, 27, 10, 38, 57, 899, DateTimeKind.Local).AddTicks(4012), "InStock", "Esse beatae quidem ad excepturi. Veritatis alias deleniti nam in aut rerum. Vel eius ea nesciunt ipsam libero. Modi excepturi et in mollitia et qui voluptatem autem. Quia commodi illum fuga repellat est minus quaerat quo.", "Product 403", "L", "Underwear" },
                    { 404, new DateTime(2020, 6, 17, 10, 38, 57, 899, DateTimeKind.Local).AddTicks(7837), "InStock", "Velit rerum quo quod aliquam et unde hic quam. Harum vero porro rerum eum animi. Mollitia dolor repudiandae facere. Molestiae amet iste et est voluptas repudiandae rem numquam. Debitis quasi ut praesentium aliquid consectetur.", "Product 404", "M", "Underwear" },
                    { 406, new DateTime(2020, 7, 31, 10, 38, 57, 900, DateTimeKind.Local).AddTicks(4077), "OutStock", "Soluta blanditiis repellat reiciendis voluptatem impedit totam quia nihil. Optio rerum officia vero tempora ullam autem. Minima aut in qui quae sit impedit aliquam quis. Voluptatibus omnis quis non fuga molestiae qui placeat officiis.", "Product 406", "XS", "Accessory" },
                    { 437, new DateTime(2020, 8, 9, 10, 38, 57, 911, DateTimeKind.Local).AddTicks(9902), "OutStock", "Rem facilis nulla esse dicta voluptate expedita vitae sequi. A rerum consequatur repudiandae natus. Non dolore non a esse eos fugit. Odit aut molestiae possimus quisquam laborum tempore molestiae.", "Product 437", "M", "Accessory" },
                    { 438, new DateTime(2020, 7, 20, 10, 38, 57, 912, DateTimeKind.Local).AddTicks(4008), "InStock", "Dolores quae enim itaque. Sint velit consequuntur ut explicabo error dolorem est qui. Assumenda ex aut et. Laboriosam reprehenderit sint consequuntur cum harum. Aut et eum sit ut voluptatum optio corrupti cumque.", "Product 438", "L", "Accessory" },
                    { 439, new DateTime(2020, 7, 18, 10, 38, 57, 912, DateTimeKind.Local).AddTicks(6758), "InStock", "Qui blanditiis suscipit adipisci et eum facere magni eos. Quis ipsam commodi quia id quos nihil ipsa. Perspiciatis iure impedit inventore at nesciunt ad ullam. Consectetur laudantium iste nihil voluptatem voluptas dignissimos.", "Product 439", "L", "Underwear" },
                    { 472, new DateTime(2020, 9, 14, 10, 38, 57, 925, DateTimeKind.Local).AddTicks(1359), "OutStock", "Magni nostrum debitis consequatur consequatur ex blanditiis asperiores. Hic qui tenetur odio sunt totam. Voluptatem id numquam tempore numquam sed est. Et libero voluptatem quae nisi nemo ipsam modi.", "Product 472", "S", "Outerwear" },
                    { 473, new DateTime(2020, 8, 4, 10, 38, 57, 925, DateTimeKind.Local).AddTicks(4871), "OutStock", "Dolores tempore qui inventore illum porro facilis debitis voluptas. Omnis sit est dolor quia facilis et expedita ut. Recusandae enim est rerum saepe. Ab quia non reprehenderit suscipit. Illo expedita aut dolor et placeat voluptatibus.", "Product 473", "M", "Footwear" },
                    { 474, new DateTime(2020, 7, 18, 10, 38, 57, 925, DateTimeKind.Local).AddTicks(6467), "OutStock", "Nisi autem omnis similique molestiae. Ut sapiente omnis et. Maiores reprehenderit incidunt mollitia rerum impedit.", "Product 474", "XS", "Outerwear" },
                    { 475, new DateTime(2020, 8, 6, 10, 38, 57, 925, DateTimeKind.Local).AddTicks(8822), "OutStock", "Maiores et et velit. Libero voluptatum vel ut est omnis. Omnis ducimus iure vel sunt deserunt et necessitatibus delectus. Non ut aperiam et.", "Product 475", "S", "Footwear" },
                    { 476, new DateTime(2020, 6, 15, 10, 38, 57, 926, DateTimeKind.Local).AddTicks(1543), "OutStock", "Quo exercitationem doloremque ratione. Officia dolores dolores et nemo qui nemo suscipit distinctio. Ut reiciendis consectetur et iste doloribus. Voluptate sed aut necessitatibus ut in error unde quia.", "Product 476", "XS", "Underwear" },
                    { 477, new DateTime(2020, 7, 19, 10, 38, 57, 926, DateTimeKind.Local).AddTicks(3203), "InStock", "Praesentium autem rem illum alias. Quasi magnam impedit rerum aliquam dolorem. Libero esse deleniti non laudantium.", "Product 477", "XS", "Accessory" },
                    { 478, new DateTime(2020, 6, 23, 10, 38, 57, 926, DateTimeKind.Local).AddTicks(5405), "InStock", "Porro inventore dolor maxime consequatur. Ut repudiandae aut sint est est eius excepturi quo. Culpa commodi ea voluptate qui blanditiis doloremque officiis.", "Product 478", "L", "Underwear" },
                    { 479, new DateTime(2020, 9, 11, 10, 38, 57, 926, DateTimeKind.Local).AddTicks(8479), "OutStock", "Voluptates aperiam sint et sint blanditiis. Eum cupiditate et ea impedit molestiae ipsam placeat. Et doloremque quia error voluptatum vitae quia aut. Voluptatem delectus minus animi ducimus repudiandae ut ex aspernatur.", "Product 479", "L", "Footwear" },
                    { 480, new DateTime(2020, 6, 27, 10, 38, 57, 927, DateTimeKind.Local).AddTicks(1631), "InStock", "Autem commodi ea aut eveniet. Est omnis alias consequatur et. Iste nihil commodi odio nobis nemo non quaerat culpa. Voluptates sint id vero sed veritatis non. Aspernatur nostrum quaerat nemo perferendis mollitia.", "Product 480", "XS", "Footwear" },
                    { 481, new DateTime(2020, 9, 15, 10, 38, 57, 927, DateTimeKind.Local).AddTicks(5011), "InStock", "Distinctio temporibus totam est quisquam qui cupiditate suscipit. Similique exercitationem eius nemo omnis illo consequatur sit. Natus quae enim architecto corrupti labore eveniet maxime. Rem corrupti voluptates et cupiditate. Atque cupiditate molestiae quibusdam non cupiditate.", "Product 481", "L", "Underwear" },
                    { 482, new DateTime(2020, 9, 15, 10, 38, 57, 927, DateTimeKind.Local).AddTicks(7258), "OutStock", "Consequatur ut qui nam nostrum. Nesciunt in sint sequi. Voluptate consectetur inventore in debitis unde quas. Qui ut nesciunt ut qui nemo.", "Product 482", "L", "Accessory" },
                    { 483, new DateTime(2020, 7, 28, 10, 38, 57, 927, DateTimeKind.Local).AddTicks(9325), "OutStock", "Sit nihil repellat libero provident eius vel harum. Quo dolores quia eaque voluptatem accusantium. Quibusdam eos labore eos ut ut.", "Product 483", "L", "Outerwear" },
                    { 484, new DateTime(2020, 7, 30, 10, 38, 57, 928, DateTimeKind.Local).AddTicks(2749), "InStock", "Voluptatem quos voluptatem recusandae eum ut qui harum sunt. Sed sequi sit labore est qui ad nihil. Sed sit nisi magni. Nam at non autem odit quibusdam eveniet. Quas aut dolor et accusamus eligendi nulla atque.", "Product 484", "M", "Underwear" },
                    { 485, new DateTime(2020, 7, 29, 10, 38, 57, 928, DateTimeKind.Local).AddTicks(5288), "OutStock", "Ut fuga iure numquam cum nostrum. Necessitatibus corrupti et non corporis. Consectetur porro rerum sunt ut cum. Quaerat hic harum quia vel veniam est voluptas.", "Product 485", "S", "Underwear" },
                    { 486, new DateTime(2020, 7, 30, 10, 38, 57, 928, DateTimeKind.Local).AddTicks(8369), "InStock", "Saepe neque maxime atque ullam expedita dolorum. Et aut enim et voluptatem. Ducimus fuga non et. Aut earum omnis quam laboriosam itaque voluptatibus minima. Reiciendis inventore repudiandae enim ipsa est earum.", "Product 486", "XS", "Underwear" },
                    { 487, new DateTime(2020, 9, 6, 10, 38, 57, 929, DateTimeKind.Local).AddTicks(1943), "InStock", "Aut occaecati incidunt inventore explicabo quibusdam. Quasi quo iusto asperiores asperiores eveniet recusandae adipisci earum. Autem quia blanditiis quam autem at culpa. Sit totam aut ea voluptatem et ut. Illum est minima qui ut reiciendis rerum natus.", "Product 487", "S", "Underwear" },
                    { 488, new DateTime(2020, 7, 24, 10, 38, 57, 929, DateTimeKind.Local).AddTicks(5409), "OutStock", "Reprehenderit et sit enim. Et doloremque quidem eos fuga consequuntur temporibus. Quasi veritatis labore sapiente eos saepe eos. Culpa autem culpa magni doloremque maxime molestiae voluptatem aliquam. Libero id omnis fugit minus ratione quas.", "Product 488", "S", "Accessory" },
                    { 489, new DateTime(2020, 9, 13, 10, 38, 57, 929, DateTimeKind.Local).AddTicks(8626), "OutStock", "Ut architecto similique quia voluptas minus placeat ea fugit. Ut possimus alias hic ea cum ducimus. In nobis deleniti vel perspiciatis non ea. Nam voluptatem incidunt error necessitatibus.", "Product 489", "L", "Footwear" },
                    { 490, new DateTime(2020, 9, 8, 10, 38, 57, 930, DateTimeKind.Local).AddTicks(2226), "OutStock", "Aliquam iure dolorem doloremque aut tenetur. Voluptatibus qui quidem magni voluptatem facere at. Maiores quidem et ex itaque. Nam nulla ratione eligendi temporibus cupiditate. Error voluptatem optio vel ab sunt sapiente nam.", "Product 490", "M", "Underwear" },
                    { 491, new DateTime(2020, 7, 22, 10, 38, 57, 930, DateTimeKind.Local).AddTicks(5963), "OutStock", "Atque provident culpa aut id illum assumenda rerum omnis. Voluptates doloremque mollitia minima saepe beatae et provident. Quibusdam quaerat nam et voluptatem tenetur dolor laudantium. Dolorem eius eaque veniam. Est esse inventore officiis.", "Product 491", "XS", "Outerwear" },
                    { 492, new DateTime(2020, 8, 6, 10, 38, 57, 930, DateTimeKind.Local).AddTicks(9118), "OutStock", "Et eum amet rerum deleniti est. Aut et facere maxime enim soluta tempore iusto quia. Magnam eligendi nisi aut distinctio. Laudantium recusandae labore sed non officia cupiditate et.", "Product 492", "M", "Outerwear" },
                    { 493, new DateTime(2020, 7, 8, 10, 38, 57, 931, DateTimeKind.Local).AddTicks(1357), "OutStock", "Dolores dolores dolore quae eos omnis neque. Vero molestias dolores praesentium tempora molestiae. Eligendi atque quia exercitationem autem velit.", "Product 493", "S", "Underwear" },
                    { 494, new DateTime(2020, 7, 8, 10, 38, 57, 931, DateTimeKind.Local).AddTicks(3502), "InStock", "Numquam velit est nulla earum ea inventore. Quas et rerum sit incidunt ipsa. Molestiae est qui vel exercitationem.", "Product 494", "S", "Underwear" },
                    { 495, new DateTime(2020, 6, 23, 10, 38, 57, 931, DateTimeKind.Local).AddTicks(7298), "OutStock", "Laudantium ut doloremque necessitatibus nobis. Similique totam pariatur et ipsa similique aperiam nisi. Molestiae sit sint est cum possimus expedita et. Id velit sunt laborum vero quisquam. Et quis dolore nihil nisi voluptas consequatur.", "Product 495", "L", "Accessory" },
                    { 496, new DateTime(2020, 7, 22, 10, 38, 57, 932, DateTimeKind.Local).AddTicks(843), "OutStock", "Saepe dolores quis sint est perferendis ut. Cumque ullam voluptas delectus necessitatibus voluptatum sequi architecto praesentium. Qui aut rerum doloremque est laudantium sed rerum. Similique quasi natus quae aliquid dolor eos quia.", "Product 496", "M", "Underwear" },
                    { 497, new DateTime(2020, 7, 23, 10, 38, 57, 932, DateTimeKind.Local).AddTicks(3777), "InStock", "Similique repudiandae accusantium officia consequatur adipisci ratione. Sit consectetur maiores consequatur. Ea ut quo possimus aut vel. Non nostrum velit id ea fugiat minus reprehenderit nisi.", "Product 497", "XS", "Footwear" },
                    { 498, new DateTime(2020, 6, 20, 10, 38, 57, 932, DateTimeKind.Local).AddTicks(6753), "InStock", "Officia dolor dolores quibusdam debitis error. At eveniet quia porro quos. Itaque ut aut nulla eligendi consequatur suscipit. Molestiae non quo molestiae numquam ut quae aspernatur.", "Product 498", "L", "Footwear" },
                    { 471, new DateTime(2020, 6, 22, 10, 38, 57, 924, DateTimeKind.Local).AddTicks(8480), "InStock", "Hic molestias eum deserunt et quis omnis ut natus. Aut corrupti eveniet maiores aspernatur consectetur excepturi et. Similique cum non quo consequatur consequatur cupiditate. Et molestiae sint alias porro qui. Adipisci quos vitae at.", "Product 471", "S", "Footwear" },
                    { 470, new DateTime(2020, 7, 3, 10, 38, 57, 924, DateTimeKind.Local).AddTicks(4788), "OutStock", "Vel voluptatum quis enim sunt. Consequuntur qui aut occaecati pariatur atque. Nostrum eaque ab ex in ipsa nihil consequatur quisquam. Aut expedita odio consectetur enim aut quam voluptas.", "Product 470", "XS", "Outerwear" },
                    { 469, new DateTime(2020, 7, 2, 10, 38, 57, 924, DateTimeKind.Local).AddTicks(1909), "InStock", "Consequuntur est sit reprehenderit iusto distinctio. Quis quod reprehenderit sunt eos quo. Ducimus non et aliquam assumenda. Veniam omnis dolorum in aliquid quis quis dolorem. Tempora corporis doloribus perspiciatis incidunt repellat suscipit.", "Product 469", "L", "Accessory" },
                    { 468, new DateTime(2020, 7, 10, 10, 38, 57, 923, DateTimeKind.Local).AddTicks(8627), "InStock", "Ex nostrum qui sit vel nam omnis. Fugit earum illum dolorem quam porro ipsum veniam. Fugit corrupti et nemo corrupti. Enim voluptate maiores aliquid aut consequuntur qui aut.", "Product 468", "XS", "Underwear" },
                    { 440, new DateTime(2020, 9, 15, 10, 38, 57, 912, DateTimeKind.Local).AddTicks(9459), "InStock", "Vitae autem deserunt possimus perspiciatis sapiente. Voluptatem perspiciatis at iste voluptatibus autem magnam non ea. Recusandae et soluta fugiat. Neque veritatis autem fuga accusantium quaerat aut ipsam. Vero sit est numquam.", "Product 440", "S", "Footwear" },
                    { 441, new DateTime(2020, 9, 17, 10, 38, 57, 913, DateTimeKind.Local).AddTicks(890), "InStock", "Quia debitis cum quia. Possimus distinctio placeat dignissimos. Tempora autem eos aut nulla enim assumenda.", "Product 441", "XS", "Footwear" },
                    { 442, new DateTime(2020, 8, 6, 10, 38, 57, 913, DateTimeKind.Local).AddTicks(2966), "InStock", "Repellendus totam occaecati et molestias. Sunt blanditiis quos voluptate est vel commodi id sint. Qui est ut qui soluta alias eaque dolor quod.", "Product 442", "S", "Footwear" },
                    { 443, new DateTime(2020, 7, 11, 10, 38, 57, 913, DateTimeKind.Local).AddTicks(5040), "OutStock", "Voluptatem numquam excepturi maiores. Tempore est natus repellat qui ad eum. Beatae quaerat quidem et blanditiis. Quo velit ducimus quam illo nemo voluptatem.", "Product 443", "M", "Footwear" },
                    { 444, new DateTime(2020, 7, 31, 10, 38, 57, 913, DateTimeKind.Local).AddTicks(7583), "InStock", "Minus temporibus ut sint consequatur. Alias praesentium impedit animi. Doloremque modi in eaque fugiat explicabo aut. Ipsa quam quo praesentium autem. Ipsa dolor modi temporibus itaque quisquam sint soluta.", "Product 444", "XS", "Accessory" },
                    { 445, new DateTime(2020, 9, 1, 10, 38, 57, 914, DateTimeKind.Local).AddTicks(434), "OutStock", "Aut commodi aut magnam. Voluptatem ducimus corporis incidunt est dolores. Aut amet quos quas delectus libero modi sit. Distinctio nulla alias perspiciatis vel natus.", "Product 445", "M", "Accessory" },
                    { 446, new DateTime(2020, 8, 27, 10, 38, 57, 914, DateTimeKind.Local).AddTicks(3244), "OutStock", "Laboriosam dolorem autem eius. Exercitationem quaerat accusamus minus consectetur nulla rem sapiente. Itaque velit voluptatem velit veniam natus error totam.", "Product 446", "M", "Outerwear" },
                    { 447, new DateTime(2020, 8, 16, 10, 38, 57, 914, DateTimeKind.Local).AddTicks(4833), "InStock", "Qui suscipit rerum consequatur excepturi molestiae illum. Sint repellendus non quam qui esse. Reiciendis excepturi aspernatur autem.", "Product 447", "L", "Footwear" },
                    { 448, new DateTime(2020, 8, 18, 10, 38, 57, 914, DateTimeKind.Local).AddTicks(7689), "OutStock", "Sint debitis magni vel eos laborum quod voluptas. Tempore omnis qui non et. Molestiae aliquid praesentium quaerat voluptatem quo ratione sed id. Aperiam quia quidem molestiae enim. Accusantium non debitis eos qui et.", "Product 448", "M", "Footwear" },
                    { 449, new DateTime(2020, 6, 13, 10, 38, 57, 915, DateTimeKind.Local).AddTicks(180), "InStock", "Et occaecati ipsam consequatur eos dolorem. Quis non est sequi pariatur tenetur in sit. Pariatur architecto et et consequuntur sapiente quos. Totam odio doloremque aut voluptates aliquam culpa impedit.", "Product 449", "L", "Outerwear" },
                    { 450, new DateTime(2020, 7, 30, 10, 38, 57, 915, DateTimeKind.Local).AddTicks(2537), "InStock", "Et aut voluptas soluta libero. Delectus autem provident velit eos aut. Beatae perspiciatis nihil deleniti praesentium sed eum voluptatem dicta. Aliquam voluptatem dolorem repellendus quia eius eum.", "Product 450", "M", "Underwear" },
                    { 451, new DateTime(2020, 6, 15, 10, 38, 57, 915, DateTimeKind.Local).AddTicks(5606), "InStock", "Laudantium fugit nihil hic eos. Ut eum aperiam sunt et incidunt quo laboriosam saepe. Dicta assumenda ut animi ut. Officiis sed voluptatem sit rem dolor quo quis. Voluptatem id et sed delectus temporibus officia quis qui.", "Product 451", "XS", "Outerwear" },
                    { 452, new DateTime(2020, 9, 8, 10, 38, 57, 915, DateTimeKind.Local).AddTicks(8716), "InStock", "Officiis sit sit incidunt consequuntur et sequi. Sint qui recusandae omnis non exercitationem cumque. Recusandae harum ipsam ut impedit inventore ea sit sed. Fugiat asperiores ullam adipisci quasi accusantium inventore. Reiciendis exercitationem itaque delectus omnis unde.", "Product 452", "L", "Underwear" },
                    { 377, new DateTime(2020, 6, 17, 10, 38, 57, 889, DateTimeKind.Local).AddTicks(774), "OutStock", "Ut et nesciunt eaque ducimus qui voluptatem veniam quos. Adipisci molestias facilis minus voluptate non facere. Corrupti nulla perferendis ut corporis. Ut voluptatem odio quidem omnis quae ut ullam minus. Architecto provident numquam nam repellat.", "Product 377", "XS", "Footwear" },
                    { 453, new DateTime(2020, 7, 24, 10, 38, 57, 916, DateTimeKind.Local).AddTicks(2014), "OutStock", "Maxime repudiandae sed rem esse animi. Fugiat impedit quidem dolorem et nostrum ea. Quam dolor expedita aliquid veritatis corrupti itaque numquam qui. Illo quam aut perspiciatis consequatur suscipit quis et.", "Product 453", "L", "Underwear" },
                    { 455, new DateTime(2020, 6, 15, 10, 38, 57, 916, DateTimeKind.Local).AddTicks(9685), "OutStock", "Sunt impedit eligendi autem possimus natus vel ut. Quo occaecati magnam dolores quisquam aut. Sed animi in ipsam dignissimos.", "Product 455", "L", "Underwear" },
                    { 456, new DateTime(2020, 7, 16, 10, 38, 57, 917, DateTimeKind.Local).AddTicks(3602), "InStock", "Culpa omnis eligendi velit cumque vero. Enim impedit explicabo ratione. Maiores maiores voluptatum voluptatem eius eius incidunt nam. Et illo rerum exercitationem. Ipsa ut architecto illum quas facere et.", "Product 456", "M", "Accessory" },
                    { 457, new DateTime(2020, 8, 30, 10, 38, 57, 917, DateTimeKind.Local).AddTicks(9000), "OutStock", "Sed voluptatem earum sapiente quia asperiores rem consectetur odit. Quibusdam modi dolores consequuntur enim ipsum vel. Unde voluptas expedita rerum temporibus aut dolorum iste. Qui et dolor dolor. Ut praesentium ut nobis fugit ut quo est placeat.", "Product 457", "M", "Underwear" },
                    { 458, new DateTime(2020, 6, 15, 10, 38, 57, 918, DateTimeKind.Local).AddTicks(2755), "InStock", "Aut minus aut quidem. Blanditiis id aut unde autem dolores ea aliquid. Sapiente cum amet rerum consequatur quis aperiam voluptatem. Illo et tempora incidunt voluptatem.", "Product 458", "S", "Accessory" },
                    { 459, new DateTime(2020, 6, 24, 10, 38, 57, 918, DateTimeKind.Local).AddTicks(6607), "OutStock", "Voluptas ea nesciunt voluptas voluptas. Quaerat corporis officiis maiores. Sed aut ut atque aut facilis ducimus facere consectetur. Modi dolorem ipsum dolor sint. Eius placeat in tenetur voluptatem.", "Product 459", "XS", "Accessory" },
                    { 460, new DateTime(2020, 6, 21, 10, 38, 57, 918, DateTimeKind.Local).AddTicks(9244), "InStock", "Dolores explicabo quia vero magni deleniti consectetur suscipit. Quis animi voluptatem sed. Nostrum praesentium odit explicabo suscipit a. Similique ea deserunt fuga distinctio repellendus consequatur odit. Pariatur dolor officia qui.", "Product 460", "XS", "Footwear" },
                    { 461, new DateTime(2020, 9, 4, 10, 38, 57, 919, DateTimeKind.Local).AddTicks(1942), "InStock", "Et sunt sit eum soluta. Quas quas non beatae voluptate in. Modi praesentium unde aut doloribus libero a. Tenetur reprehenderit earum qui. Qui necessitatibus autem iste error vel tempore voluptatem officia.", "Product 461", "M", "Accessory" },
                    { 462, new DateTime(2020, 8, 8, 10, 38, 57, 919, DateTimeKind.Local).AddTicks(4437), "OutStock", "Reiciendis sed qui quae maiores minima perferendis. Impedit aspernatur sit officiis aut impedit ut. Tempora maiores et quis neque. Quod harum itaque iusto nam sunt quasi.", "Product 462", "XS", "Footwear" },
                    { 463, new DateTime(2020, 6, 25, 10, 38, 57, 919, DateTimeKind.Local).AddTicks(7616), "InStock", "Sunt accusamus dicta et. Dolorem et architecto voluptatibus. Alias quis sed temporibus. Velit incidunt perferendis tempora aut veniam aut unde.", "Product 463", "L", "Underwear" },
                    { 464, new DateTime(2020, 7, 2, 10, 38, 57, 920, DateTimeKind.Local).AddTicks(633), "InStock", "Sequi fugiat quia dignissimos dolorem tenetur. Labore modi sit sunt ipsum. Cumque occaecati et amet asperiores ipsam repudiandae et.", "Product 464", "L", "Underwear" },
                    { 465, new DateTime(2020, 6, 30, 10, 38, 57, 923, DateTimeKind.Local).AddTicks(1238), "InStock", "Est amet id sunt aut autem qui. Iste sed dicta sed illum fugiat. Natus quidem beatae officiis eveniet aliquid. Nihil iusto consequatur quibusdam ut sunt ut nam debitis.", "Product 465", "S", "Underwear" },
                    { 466, new DateTime(2020, 9, 12, 10, 38, 57, 923, DateTimeKind.Local).AddTicks(4008), "OutStock", "Est inventore accusantium corporis nemo ab architecto. Vero id deserunt sequi sed. Ea quo sed numquam hic libero. Et dolor ipsa rerum et. Laboriosam aperiam quia reprehenderit animi omnis.", "Product 466", "XS", "Outerwear" },
                    { 467, new DateTime(2020, 8, 6, 10, 38, 57, 923, DateTimeKind.Local).AddTicks(5773), "InStock", "Neque non adipisci qui. Quam assumenda laudantium vitae laudantium ducimus. Qui exercitationem error eligendi corrupti officiis modi commodi.", "Product 467", "S", "Underwear" },
                    { 454, new DateTime(2020, 7, 27, 10, 38, 57, 916, DateTimeKind.Local).AddTicks(6756), "InStock", "Aut atque totam eos excepturi est. Ullam numquam maiores ipsam minus quod qui. Optio omnis dolores commodi ad quo et illo. Officiis voluptatum et repellat animi sit. Officiis similique enim aspernatur modi.", "Product 454", "M", "Underwear" },
                    { 376, new DateTime(2020, 6, 30, 10, 38, 57, 888, DateTimeKind.Local).AddTicks(5809), "OutStock", "Voluptatem enim aliquam odit cumque voluptas sit atque ipsa. Labore doloribus odio vel aut ex. Et repellendus suscipit et et vel. Maiores dolore ut saepe iste qui.", "Product 376", "L", "Accessory" },
                    { 375, new DateTime(2020, 9, 9, 10, 38, 57, 888, DateTimeKind.Local).AddTicks(1848), "InStock", "Aut et debitis repellendus. Laudantium voluptas ut delectus animi repudiandae nihil. Qui temporibus qui ex at sit reprehenderit distinctio quos. Harum est illo commodi ut consequatur molestiae. Ut nemo facilis quia.", "Product 375", "XS", "Accessory" },
                    { 374, new DateTime(2020, 6, 27, 10, 38, 57, 887, DateTimeKind.Local).AddTicks(7284), "OutStock", "Perferendis dolores perferendis porro unde quo tempore. Et quidem sed ab voluptatum vel rerum consectetur. Ea ea numquam laborum. Dignissimos facilis fugiat incidunt id commodi doloribus omnis rerum. Aut culpa quam voluptate sit qui quis quasi.", "Product 374", "L", "Footwear" },
                    { 284, new DateTime(2020, 7, 8, 10, 38, 57, 841, DateTimeKind.Local).AddTicks(2673), "InStock", "Fugiat est repudiandae veritatis. Commodi ut error suscipit rerum adipisci aut quo. Aliquid incidunt voluptatem harum nihil explicabo. Aperiam debitis qui unde cumque consectetur iusto dolore velit. Voluptas sit eum non excepturi.", "Product 284", "L", "Accessory" },
                    { 285, new DateTime(2020, 7, 5, 10, 38, 57, 842, DateTimeKind.Local).AddTicks(383), "InStock", "Non deserunt molestiae aut sint asperiores vero. Ab omnis ut et fugiat. Animi distinctio et est sunt provident corrupti eum quod. Provident necessitatibus dolorum eveniet omnis ab dicta quasi illum. Quibusdam quae enim sequi commodi adipisci rerum.", "Product 285", "S", "Outerwear" },
                    { 286, new DateTime(2020, 8, 10, 10, 38, 57, 842, DateTimeKind.Local).AddTicks(8141), "OutStock", "Animi eum velit excepturi optio voluptas. Quo nesciunt inventore temporibus voluptatem tempore at. Iure esse reprehenderit perspiciatis architecto libero nostrum rerum. Minus qui et dolor facere maiores itaque perferendis enim. Quo ut aut fugit qui eligendi adipisci voluptatum.", "Product 286", "XS", "Outerwear" },
                    { 287, new DateTime(2020, 6, 27, 10, 38, 57, 843, DateTimeKind.Local).AddTicks(3130), "InStock", "Rem cumque voluptatibus facilis eveniet aliquid cupiditate. Est earum molestiae soluta dolor eum aut delectus non. Omnis velit reiciendis provident architecto est omnis.", "Product 287", "S", "Accessory" },
                    { 288, new DateTime(2020, 6, 19, 10, 38, 57, 843, DateTimeKind.Local).AddTicks(7924), "OutStock", "Dolores dolores nobis rerum odit corporis. Veniam et dolor laborum minima ratione. Sapiente distinctio vero similique voluptatum unde. Quisquam iste molestiae sed.", "Product 288", "S", "Footwear" },
                    { 289, new DateTime(2020, 6, 28, 10, 38, 57, 844, DateTimeKind.Local).AddTicks(3500), "OutStock", "Inventore repudiandae suscipit a harum velit. Id esse ab laudantium aut tenetur quae vero iste. Iure similique est perferendis et. A maiores recusandae magni ut eos.", "Product 289", "S", "Underwear" },
                    { 290, new DateTime(2020, 6, 23, 10, 38, 57, 844, DateTimeKind.Local).AddTicks(8205), "OutStock", "Adipisci rerum natus alias ab sit ut non. Ad sed commodi eaque sed sed. Culpa aut nihil consequuntur placeat non animi labore.", "Product 290", "M", "Accessory" },
                    { 291, new DateTime(2020, 6, 20, 10, 38, 57, 845, DateTimeKind.Local).AddTicks(3199), "OutStock", "Mollitia ut sint nam. Incidunt aut consequuntur consequatur aspernatur illum ut rerum est. Ex vitae facere rerum at. Non odio unde aliquam autem.", "Product 291", "XS", "Underwear" },
                    { 292, new DateTime(2020, 8, 12, 10, 38, 57, 845, DateTimeKind.Local).AddTicks(8120), "InStock", "Maxime occaecati totam quisquam officia quia fuga. Doloribus rerum nostrum quisquam sit ea eum totam ipsam. Ut esse distinctio sed earum non quasi.", "Product 292", "XS", "Footwear" },
                    { 293, new DateTime(2020, 8, 20, 10, 38, 57, 846, DateTimeKind.Local).AddTicks(5158), "OutStock", "Impedit sequi quasi aliquid qui perferendis nam. Dolor occaecati voluptas unde nostrum. Ut et amet exercitationem aut quod enim corporis ut. Placeat in maiores ut eveniet ipsa. Laborum dolorem voluptatem eius provident qui alias.", "Product 293", "M", "Accessory" },
                    { 294, new DateTime(2020, 9, 10, 10, 38, 57, 846, DateTimeKind.Local).AddTicks(9922), "OutStock", "Omnis nihil voluptatibus dolor delectus voluptatum. Quaerat eius aut sit ut cum ab cumque. Tempora qui est culpa dolorem quo quia corporis.", "Product 294", "M", "Footwear" },
                    { 295, new DateTime(2020, 8, 13, 10, 38, 57, 847, DateTimeKind.Local).AddTicks(5162), "OutStock", "Nisi ratione ut quaerat qui ut. Tempora vel porro nobis voluptatem voluptatem qui. Quis deserunt enim quia. Quibusdam similique expedita rerum facere saepe facere et.", "Product 295", "S", "Accessory" },
                    { 296, new DateTime(2020, 9, 9, 10, 38, 57, 848, DateTimeKind.Local).AddTicks(834), "InStock", "Eius quia voluptas omnis maxime autem. Labore sapiente laboriosam ab corrupti fuga laudantium. Omnis tempora qui sunt. Facere ducimus aliquam neque corrupti. Quae quaerat omnis non.", "Product 296", "M", "Underwear" },
                    { 297, new DateTime(2020, 7, 19, 10, 38, 57, 848, DateTimeKind.Local).AddTicks(6280), "OutStock", "Amet quo voluptatum laudantium ad animi quisquam optio. Ipsum explicabo vel deleniti ipsa. Aspernatur recusandae autem quas ad. Aut exercitationem omnis dignissimos ut veniam laborum voluptatem.", "Product 297", "S", "Footwear" },
                    { 298, new DateTime(2020, 8, 17, 10, 38, 57, 849, DateTimeKind.Local).AddTicks(522), "InStock", "Rerum commodi sint rerum id. Autem deserunt vel assumenda eum repellendus. Fuga et quo molestiae enim beatae saepe cum.", "Product 298", "XS", "Footwear" },
                    { 299, new DateTime(2020, 8, 19, 10, 38, 57, 849, DateTimeKind.Local).AddTicks(7951), "InStock", "Ipsum totam rerum ea sit quis natus mollitia. Error sed accusamus et impedit. Velit magni voluptas nostrum dignissimos non nostrum dolorum deleniti. Exercitationem sed rerum cumque provident voluptas quasi. Eos illo quo et esse et ut.", "Product 299", "L", "Accessory" },
                    { 300, new DateTime(2020, 8, 25, 10, 38, 57, 850, DateTimeKind.Local).AddTicks(1991), "InStock", "Ipsum aperiam autem officia vero. Similique animi sit qui voluptatem inventore. Molestias saepe nisi numquam porro vero unde.", "Product 300", "L", "Underwear" },
                    { 301, new DateTime(2020, 9, 7, 10, 38, 57, 850, DateTimeKind.Local).AddTicks(6889), "OutStock", "Eveniet est et sit qui atque ipsa exercitationem velit. Est eum consequatur sit ipsa. Sunt aut nobis ea quae modi eligendi et eligendi.", "Product 301", "S", "Underwear" },
                    { 302, new DateTime(2020, 8, 30, 10, 38, 57, 851, DateTimeKind.Local).AddTicks(3428), "OutStock", "Et doloribus voluptas minima nemo aliquam nulla. Ut qui sint magni ut id non esse. Vel aut aut eos. Quas quis facere impedit reiciendis. Neque dolores consequuntur fuga quia cumque aperiam.", "Product 302", "XS", "Footwear" },
                    { 303, new DateTime(2020, 7, 18, 10, 38, 57, 851, DateTimeKind.Local).AddTicks(8031), "OutStock", "Commodi qui enim ex aliquid ducimus qui. Cum quia sit minima. Non ab impedit eaque similique alias. Ipsam aut eveniet molestiae.", "Product 303", "L", "Accessory" },
                    { 304, new DateTime(2020, 8, 20, 10, 38, 57, 852, DateTimeKind.Local).AddTicks(3922), "InStock", "Repellendus quo debitis voluptatibus culpa impedit et odit. Consequatur nemo voluptas magni rerum. Voluptas recusandae aut nobis accusantium repellat. Omnis explicabo recusandae ab laborum voluptas laboriosam porro. Sed quidem impedit voluptatem.", "Product 304", "S", "Underwear" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Arrived", "Availability", "Description", "Name", "Size", "Type" },
                values: new object[,]
                {
                    { 305, new DateTime(2020, 8, 28, 10, 38, 57, 852, DateTimeKind.Local).AddTicks(9907), "InStock", "Nemo quasi explicabo error voluptate magni. Est sint non nobis a aut. Facere rerum nesciunt et facere. Qui quam laboriosam unde aut. Et animi sed beatae minus fuga tenetur officia voluptatem.", "Product 305", "XS", "Outerwear" },
                    { 306, new DateTime(2020, 6, 12, 10, 38, 57, 853, DateTimeKind.Local).AddTicks(4640), "InStock", "Molestias sint consequatur sit voluptas eum voluptates. Dolore assumenda quia est et recusandae ipsa. Animi ratione quis vel in. Et delectus odit veritatis sint.", "Product 306", "M", "Footwear" },
                    { 307, new DateTime(2020, 7, 25, 10, 38, 57, 853, DateTimeKind.Local).AddTicks(8869), "OutStock", "Quia eum a consectetur dignissimos est corrupti. Labore voluptas delectus atque sint. Sed assumenda incidunt vitae qui. Sint voluptate nulla officia.", "Product 307", "L", "Underwear" },
                    { 308, new DateTime(2020, 7, 17, 10, 38, 57, 854, DateTimeKind.Local).AddTicks(3045), "InStock", "Porro minus autem sunt deserunt velit nostrum voluptatem molestias. Est assumenda qui totam quod ut nisi harum. Ab ex occaecati voluptate.", "Product 308", "XS", "Accessory" },
                    { 309, new DateTime(2020, 8, 3, 10, 38, 57, 855, DateTimeKind.Local).AddTicks(298), "OutStock", "Aliquam quaerat et et aliquam sint repudiandae cumque. Veniam non quis recusandae nisi ad blanditiis. Eos soluta aspernatur ut doloremque quasi enim. Vel quod odio et et blanditiis nisi. Perferendis totam aut dignissimos nemo voluptatum dolores sint dignissimos.", "Product 309", "S", "Underwear" },
                    { 310, new DateTime(2020, 8, 9, 10, 38, 57, 855, DateTimeKind.Local).AddTicks(4563), "InStock", "Aperiam pariatur nemo pariatur quidem deleniti rem ab nihil. Optio similique officia incidunt veniam necessitatibus perferendis delectus. Mollitia ut debitis rem.", "Product 310", "S", "Footwear" },
                    { 283, new DateTime(2020, 8, 5, 10, 38, 57, 840, DateTimeKind.Local).AddTicks(5814), "InStock", "Repellendus temporibus vitae quisquam quibusdam odit consectetur autem. Laboriosam architecto sapiente eum iure. Minus non est non numquam dolores temporibus ut sunt. Laudantium eum nihil tenetur repudiandae vel.", "Product 283", "L", "Footwear" },
                    { 282, new DateTime(2020, 6, 29, 10, 38, 57, 839, DateTimeKind.Local).AddTicks(9856), "OutStock", "Eaque quis quaerat quasi optio. Ut dolores quia id omnis illo voluptatem minus. Dolores in et et in. Error modi optio quidem.", "Product 282", "XS", "Accessory" },
                    { 281, new DateTime(2020, 7, 18, 10, 38, 57, 839, DateTimeKind.Local).AddTicks(5057), "OutStock", "Ut porro nostrum quas sunt ut magni nemo est. Ex unde laudantium dolorem dolorem non. Odit facere odio aut illum laudantium sint. Atque in est deleniti nisi in quas.", "Product 281", "M", "Accessory" },
                    { 280, new DateTime(2020, 7, 3, 10, 38, 57, 838, DateTimeKind.Local).AddTicks(9049), "OutStock", "Repellat est beatae alias ex et. Incidunt alias excepturi possimus sed eaque et. Voluptas rerum rerum maiores commodi ut architecto sit. At corrupti dolores unde omnis fuga tempora culpa.", "Product 280", "L", "Outerwear" },
                    { 252, new DateTime(2020, 6, 12, 10, 38, 57, 823, DateTimeKind.Local).AddTicks(4201), "OutStock", "Sed repudiandae praesentium alias. Sapiente illo enim ipsa rerum ex ut aut. Commodi facilis molestiae voluptates ipsam voluptas tempore eligendi eius. Sapiente aut blanditiis et quos. Possimus consequatur necessitatibus quia.", "Product 252", "M", "Outerwear" },
                    { 253, new DateTime(2020, 7, 16, 10, 38, 57, 823, DateTimeKind.Local).AddTicks(9055), "OutStock", "Exercitationem nihil accusamus voluptatem est quae magni. Omnis labore facere aut sapiente veniam repellendus nisi sit. Sed aut ducimus quia et aperiam minus.", "Product 253", "S", "Accessory" },
                    { 254, new DateTime(2020, 6, 28, 10, 38, 57, 824, DateTimeKind.Local).AddTicks(3620), "OutStock", "Quo est qui illo atque. Ipsum dolores veritatis eaque accusamus aut rerum porro alias. Doloremque minus voluptas ea magnam quam voluptas.", "Product 254", "L", "Outerwear" },
                    { 255, new DateTime(2020, 9, 16, 10, 38, 57, 824, DateTimeKind.Local).AddTicks(9332), "InStock", "Rerum autem ducimus eum quam voluptatum asperiores ipsum. Sunt amet omnis asperiores quisquam eligendi. Libero perferendis doloribus aut et voluptas est accusantium. Sed et ut qui dolore.", "Product 255", "L", "Underwear" },
                    { 256, new DateTime(2020, 9, 4, 10, 38, 57, 825, DateTimeKind.Local).AddTicks(4268), "OutStock", "Temporibus reprehenderit in rerum qui autem. Molestias ab quis et et soluta facere accusamus placeat. Laudantium aliquam sed esse placeat qui inventore fugiat.", "Product 256", "L", "Accessory" },
                    { 257, new DateTime(2020, 8, 20, 10, 38, 57, 825, DateTimeKind.Local).AddTicks(9569), "OutStock", "Vero consectetur vel dolor voluptatem. Temporibus cupiditate facere nisi itaque tempora. Qui dignissimos nam aperiam a hic aut sunt. Sit consequatur quos autem saepe aut.", "Product 257", "XS", "Outerwear" },
                    { 258, new DateTime(2020, 6, 21, 10, 38, 57, 826, DateTimeKind.Local).AddTicks(5875), "OutStock", "Quia pariatur sed in sed. A quae iste corrupti harum et inventore velit. Asperiores totam sunt expedita rerum dolorem aut at voluptas. Quae eos aperiam labore aspernatur voluptas voluptatem accusantium.", "Product 258", "L", "Underwear" },
                    { 259, new DateTime(2020, 7, 16, 10, 38, 57, 827, DateTimeKind.Local).AddTicks(1017), "InStock", "Iure qui velit ut et dolor vel id reiciendis. Ipsa non iure et aliquid saepe. Voluptas fuga sunt sit fugit officia alias sunt fugit.", "Product 259", "S", "Accessory" },
                    { 260, new DateTime(2020, 6, 19, 10, 38, 57, 827, DateTimeKind.Local).AddTicks(6076), "InStock", "Iusto velit tempore dolorum voluptates tempore. Sunt ipsa quae qui. Aperiam et qui quisquam aut cupiditate. Aliquid similique ut quos consectetur sequi repellat aut.", "Product 260", "XS", "Footwear" },
                    { 261, new DateTime(2020, 8, 3, 10, 38, 57, 828, DateTimeKind.Local).AddTicks(1964), "OutStock", "Natus sunt et autem libero modi aperiam molestiae quia. Id vero et quas cumque. Et veniam ex optio qui quo. Neque culpa a dicta nihil neque ipsum ut.", "Product 261", "S", "Outerwear" },
                    { 262, new DateTime(2020, 6, 29, 10, 38, 57, 828, DateTimeKind.Local).AddTicks(7167), "InStock", "Itaque sunt voluptas fugiat mollitia quis. Exercitationem ea labore ratione sint veritatis harum. Possimus vitae cupiditate error architecto excepturi. Sapiente et aut ut perspiciatis.", "Product 262", "S", "Accessory" },
                    { 263, new DateTime(2020, 8, 17, 10, 38, 57, 829, DateTimeKind.Local).AddTicks(2360), "InStock", "Eos maxime aliquid nihil explicabo. Voluptates ut id necessitatibus facere similique. Officiis est tempora enim consequuntur tempora quidem. Qui eos consequatur totam reprehenderit dolores.", "Product 263", "L", "Underwear" },
                    { 264, new DateTime(2020, 8, 14, 10, 38, 57, 829, DateTimeKind.Local).AddTicks(6905), "OutStock", "Distinctio eaque et aspernatur voluptas sit natus culpa qui. In fugit unde et nobis eum. Aliquam et optio aut laboriosam et.", "Product 264", "S", "Footwear" },
                    { 311, new DateTime(2020, 7, 4, 10, 38, 57, 855, DateTimeKind.Local).AddTicks(9899), "InStock", "Ipsam sit dolorem nobis aut quis officia. Et id quos explicabo quae. Beatae esse perferendis facere nihil sed quaerat. Et dolore optio aut consequuntur ipsa impedit ipsam.", "Product 311", "S", "Underwear" },
                    { 265, new DateTime(2020, 8, 17, 10, 38, 57, 830, DateTimeKind.Local).AddTicks(1087), "OutStock", "Enim nam ipsa commodi dicta. Dolore vel quidem at est molestias ex libero. Dignissimos libero qui quam sunt labore.", "Product 265", "M", "Underwear" },
                    { 267, new DateTime(2020, 8, 18, 10, 38, 57, 831, DateTimeKind.Local).AddTicks(4178), "InStock", "Quis et est eum libero non. Id nam modi mollitia. Iste non fugit enim eos non occaecati fugit. Voluptatum labore culpa fugit. Ipsam repudiandae sunt perferendis modi nostrum.", "Product 267", "L", "Accessory" },
                    { 268, new DateTime(2020, 8, 12, 10, 38, 57, 831, DateTimeKind.Local).AddTicks(8386), "InStock", "Repellendus assumenda sunt voluptatem vero est qui. Aut id aut non odio. Excepturi ut enim qui quo voluptas iure.", "Product 268", "L", "Accessory" },
                    { 269, new DateTime(2020, 8, 11, 10, 38, 57, 832, DateTimeKind.Local).AddTicks(2786), "OutStock", "Sed nostrum qui distinctio rerum. Neque vero voluptate eos officia nisi quam sint exercitationem. Ut doloremque vitae quasi porro.", "Product 269", "S", "Footwear" },
                    { 270, new DateTime(2020, 6, 18, 10, 38, 57, 832, DateTimeKind.Local).AddTicks(7648), "OutStock", "Dolore qui non autem in. Veritatis debitis ratione odio. Repudiandae odio repudiandae ut quia necessitatibus quibusdam. Nisi sequi accusamus quisquam et nostrum.", "Product 270", "S", "Underwear" },
                    { 271, new DateTime(2020, 7, 17, 10, 38, 57, 833, DateTimeKind.Local).AddTicks(2809), "InStock", "Ea commodi voluptatum quo aliquid quae ipsa vero. Qui iste quibusdam quia. Sit aspernatur esse fuga ratione aliquid. Sequi praesentium unde dicta molestias consequatur.", "Product 271", "M", "Outerwear" },
                    { 272, new DateTime(2020, 8, 14, 10, 38, 57, 833, DateTimeKind.Local).AddTicks(8800), "OutStock", "Dolorem expedita iure dolorem iure aut laudantium. Ad et reprehenderit molestiae. Laudantium enim voluptate quas sit sequi ut ullam voluptatem. Nihil corporis est fuga provident est nulla aut velit.", "Product 272", "L", "Accessory" },
                    { 273, new DateTime(2020, 8, 7, 10, 38, 57, 834, DateTimeKind.Local).AddTicks(3953), "InStock", "Repellat veritatis sit non et. Voluptatem possimus praesentium iste culpa dignissimos veniam incidunt. Pariatur doloremque est voluptatem voluptate. Iusto velit exercitationem suscipit natus ex.", "Product 273", "XS", "Footwear" },
                    { 274, new DateTime(2020, 9, 18, 10, 38, 57, 835, DateTimeKind.Local).AddTicks(1076), "OutStock", "Dignissimos labore ut eos. Magnam maxime et voluptatum inventore eligendi est. Voluptas aliquam sapiente voluptate fugit et harum odit aperiam. Ipsum aliquid facere aut iure. Vero saepe incidunt similique voluptatum dolore.", "Product 274", "L", "Underwear" },
                    { 275, new DateTime(2020, 8, 14, 10, 38, 57, 835, DateTimeKind.Local).AddTicks(9254), "OutStock", "Mollitia quia nihil id nesciunt accusantium saepe placeat ratione. In dolorem exercitationem sunt perspiciatis error dicta ex dignissimos. Odio esse architecto nulla fuga totam. Doloremque in et animi quibusdam maxime nobis. Ab consequatur sed omnis quis corporis unde est debitis.", "Product 275", "L", "Accessory" },
                    { 276, new DateTime(2020, 7, 20, 10, 38, 57, 836, DateTimeKind.Local).AddTicks(4708), "OutStock", "Nihil optio alias rerum cum ea rem quidem. Porro quo reiciendis ad. Aut placeat officiis autem. Dolor dolorum et fugiat et sapiente nesciunt et placeat.", "Product 276", "M", "Footwear" },
                    { 277, new DateTime(2020, 8, 13, 10, 38, 57, 836, DateTimeKind.Local).AddTicks(9238), "InStock", "Error est doloribus voluptates ut cum consequatur. Officia optio facilis et amet ut maiores suscipit aperiam. Ducimus qui modi recusandae molestias.", "Product 277", "L", "Footwear" },
                    { 278, new DateTime(2020, 7, 16, 10, 38, 57, 837, DateTimeKind.Local).AddTicks(6093), "InStock", "Sed velit harum minima et id consequatur debitis. Dolorem iure modi et consequatur. Magni et impedit deserunt perspiciatis ut. Harum magnam velit nisi illo. Minima provident et quo rerum rem aut eius impedit.", "Product 278", "L", "Underwear" },
                    { 279, new DateTime(2020, 8, 8, 10, 38, 57, 838, DateTimeKind.Local).AddTicks(3012), "InStock", "Reprehenderit pariatur reprehenderit iste quisquam deserunt hic voluptatem. Optio enim atque cupiditate impedit temporibus. Temporibus molestias magnam quam eaque ratione. Repellendus ut et ut. Sed suscipit rerum ut amet non qui ducimus debitis.", "Product 279", "S", "Accessory" },
                    { 266, new DateTime(2020, 6, 26, 10, 38, 57, 830, DateTimeKind.Local).AddTicks(8186), "OutStock", "Mollitia molestiae accusamus repellendus iste. Laborum eos non at modi voluptate. Possimus est mollitia neque possimus animi perspiciatis. Aliquam ea qui voluptatibus dolore quia non facere reiciendis. Voluptatum eos ipsum adipisci culpa vero vitae.", "Product 266", "S", "Outerwear" },
                    { 999, new DateTime(2020, 7, 9, 10, 38, 58, 91, DateTimeKind.Local).AddTicks(6276), "OutStock", "Dolores iste et eveniet in consequatur. Eos aut harum quas odit deleniti et maxime. Eum voluptatem pariatur ut exercitationem reiciendis quod. Voluptatem facilis sit quis rerum odio qui et ad. Voluptates excepturi recusandae nisi perferendis est.", "Product 999", "L", "Outerwear" },
                    { 312, new DateTime(2020, 7, 17, 10, 38, 57, 856, DateTimeKind.Local).AddTicks(4841), "InStock", "Dignissimos est excepturi voluptates mollitia at sunt. Voluptas autem quisquam in voluptatem nostrum itaque voluptas. Sapiente omnis ipsum consequuntur et. Aut veritatis beatae inventore rem.", "Product 312", "L", "Underwear" },
                    { 314, new DateTime(2020, 6, 24, 10, 38, 57, 857, DateTimeKind.Local).AddTicks(5344), "OutStock", "Asperiores perferendis non est. Aut amet nobis et reprehenderit dicta fugit asperiores. Possimus nihil laborum quia iusto. Repellendus illo et molestiae magni magni dolores dolor alias. In nemo inventore quis accusantium hic.", "Product 314", "L", "Outerwear" },
                    { 347, new DateTime(2020, 6, 22, 10, 38, 57, 874, DateTimeKind.Local).AddTicks(1192), "OutStock", "Magnam veritatis quae optio. Quia aut id suscipit qui dicta. Exercitationem recusandae repellendus sint. Veritatis sint doloribus id qui. Dignissimos aut fugit et molestiae ullam ratione aliquam illum.", "Product 347", "S", "Footwear" },
                    { 348, new DateTime(2020, 8, 7, 10, 38, 57, 874, DateTimeKind.Local).AddTicks(8299), "OutStock", "Neque laudantium vel officiis eos eos quidem hic. Esse nisi placeat repudiandae ipsum voluptate. Omnis quos neque quas delectus vero est sed illo. Suscipit assumenda sint ex impedit ratione dignissimos accusantium. Consequatur illo quas ullam fugit et qui.", "Product 348", "S", "Accessory" },
                    { 349, new DateTime(2020, 7, 2, 10, 38, 57, 875, DateTimeKind.Local).AddTicks(3266), "InStock", "Sed ut quo earum. Assumenda aspernatur magni quas dolore. Et minus facilis amet. Assumenda molestiae in omnis ea beatae corporis. Quod voluptatem temporibus libero necessitatibus.", "Product 349", "M", "Underwear" },
                    { 350, new DateTime(2020, 7, 9, 10, 38, 57, 875, DateTimeKind.Local).AddTicks(7218), "InStock", "Sunt error qui aliquid ut minima quas dolores. Velit non voluptas ea. Aut dolor ex omnis quia iste corporis est.", "Product 350", "S", "Footwear" },
                    { 351, new DateTime(2020, 7, 9, 10, 38, 57, 876, DateTimeKind.Local).AddTicks(4576), "InStock", "Sunt tempore ut voluptatem et id fugit explicabo omnis. Ut assumenda sequi voluptas. Velit ut dolore magni omnis est. Libero maiores consectetur qui sapiente consequatur dicta ut dolorem. Et ullam maxime cupiditate enim earum dolores.", "Product 351", "L", "Footwear" },
                    { 352, new DateTime(2020, 9, 16, 10, 38, 57, 877, DateTimeKind.Local).AddTicks(1749), "OutStock", "Aut ab laboriosam aut ipsa fuga ullam odio velit. Aut sit quia eaque. Quasi repellat quas dolorem molestias minus et voluptatem.", "Product 352", "L", "Outerwear" },
                    { 353, new DateTime(2020, 7, 9, 10, 38, 57, 877, DateTimeKind.Local).AddTicks(8747), "OutStock", "Eos quibusdam aut asperiores praesentium. Sit dolorem corrupti debitis excepturi ut ducimus sunt quis. Est quia nihil velit incidunt vero tempore.", "Product 353", "S", "Underwear" },
                    { 354, new DateTime(2020, 8, 13, 10, 38, 57, 878, DateTimeKind.Local).AddTicks(4541), "InStock", "Illo excepturi et et hic. Id nihil qui non quae laborum. At qui commodi voluptatem animi dolores.", "Product 354", "S", "Outerwear" },
                    { 355, new DateTime(2020, 8, 26, 10, 38, 57, 879, DateTimeKind.Local).AddTicks(3543), "InStock", "Sunt repellat omnis dicta quos quos. Labore eum reprehenderit ut sapiente et quaerat possimus. Magni explicabo iste quia commodi facere corporis est blanditiis. Sint quia nesciunt possimus sapiente.", "Product 355", "M", "Underwear" },
                    { 356, new DateTime(2020, 7, 10, 10, 38, 57, 879, DateTimeKind.Local).AddTicks(8795), "OutStock", "Asperiores exercitationem similique fugiat. Est placeat non minus. Delectus voluptatem beatae corrupti. Suscipit maiores unde voluptas autem et voluptate architecto occaecati. Ipsam et et porro sed.", "Product 356", "XS", "Accessory" },
                    { 357, new DateTime(2020, 7, 15, 10, 38, 57, 880, DateTimeKind.Local).AddTicks(1761), "InStock", "Ipsum nisi vel optio. Ut temporibus molestiae nisi sit. Dolores quam vel id qui.", "Product 357", "L", "Accessory" },
                    { 358, new DateTime(2020, 9, 6, 10, 38, 57, 880, DateTimeKind.Local).AddTicks(7377), "OutStock", "Animi autem dolores inventore laboriosam. Ipsam repellendus explicabo doloremque quasi magni. Eaque qui laborum quo perferendis voluptatem. Est ea voluptas quia voluptatum quibusdam quis ad. Quas ut deleniti eius.", "Product 358", "L", "Accessory" },
                    { 359, new DateTime(2020, 8, 21, 10, 38, 57, 881, DateTimeKind.Local).AddTicks(1091), "OutStock", "Ipsum fuga molestias provident placeat illo voluptatum recusandae qui. Rerum accusamus quasi vel. Provident atque architecto tenetur a.", "Product 359", "S", "Outerwear" },
                    { 360, new DateTime(2020, 6, 16, 10, 38, 57, 881, DateTimeKind.Local).AddTicks(5605), "InStock", "Itaque molestiae ducimus molestias doloribus voluptatibus consequuntur soluta a. Qui corrupti sed fugit quaerat corporis sed adipisci. Illo illo itaque nulla aut quia.", "Product 360", "S", "Footwear" },
                    { 361, new DateTime(2020, 6, 18, 10, 38, 57, 881, DateTimeKind.Local).AddTicks(9615), "InStock", "Ut animi natus omnis in ipsam est non nobis. Consequatur veniam incidunt facere dicta aut est. Modi veniam unde autem.", "Product 361", "S", "Accessory" },
                    { 362, new DateTime(2020, 8, 28, 10, 38, 57, 882, DateTimeKind.Local).AddTicks(3569), "OutStock", "Et laboriosam aut incidunt eos consequatur officiis. Vel commodi veritatis animi et accusamus sint laboriosam. Nostrum est libero tenetur dignissimos.", "Product 362", "L", "Outerwear" },
                    { 363, new DateTime(2020, 9, 18, 10, 38, 57, 882, DateTimeKind.Local).AddTicks(8680), "InStock", "Reiciendis vero non deleniti rerum optio placeat eaque. Magni alias quisquam vel at placeat. Excepturi non hic rem aut illo. Sed ut quisquam et molestias neque.", "Product 363", "L", "Underwear" },
                    { 364, new DateTime(2020, 8, 29, 10, 38, 57, 883, DateTimeKind.Local).AddTicks(3663), "OutStock", "Est maiores cupiditate exercitationem voluptatem assumenda beatae quia. Deserunt ad nihil quibusdam eum esse cupiditate dolores et. Eum laudantium deleniti nostrum et. Alias necessitatibus perspiciatis velit.", "Product 364", "M", "Footwear" },
                    { 365, new DateTime(2020, 8, 7, 10, 38, 57, 883, DateTimeKind.Local).AddTicks(9574), "OutStock", "Qui non aliquid mollitia eius commodi odit et. Eos error modi nostrum enim aliquid quae. Nulla et nemo accusamus vel deserunt iste aut. Deleniti dolores aut molestiae assumenda et nulla sequi.", "Product 365", "L", "Outerwear" },
                    { 366, new DateTime(2020, 7, 8, 10, 38, 57, 884, DateTimeKind.Local).AddTicks(5524), "InStock", "Ut omnis itaque voluptas sit. Incidunt laborum ducimus ut assumenda. Et voluptas ipsam illum libero fuga. Id in ea nobis reprehenderit quia a est vitae. Ipsum est est quidem assumenda odit.", "Product 366", "L", "Accessory" },
                    { 367, new DateTime(2020, 8, 20, 10, 38, 57, 884, DateTimeKind.Local).AddTicks(9433), "InStock", "Et sunt sint autem commodi occaecati autem perferendis qui. Ratione qui nisi debitis dolores aut provident. Totam facilis nostrum beatae. Asperiores aspernatur mollitia et iure aliquid.", "Product 367", "S", "Underwear" },
                    { 368, new DateTime(2020, 8, 19, 10, 38, 57, 885, DateTimeKind.Local).AddTicks(4008), "OutStock", "Itaque eius amet accusantium. Dolore ut quam eius maiores dolores debitis. Impedit odit fugiat ut ducimus et accusantium sed aperiam. Voluptate doloremque saepe exercitationem. Quis rem omnis sed ut explicabo cum beatae maiores.", "Product 368", "XS", "Footwear" },
                    { 369, new DateTime(2020, 8, 29, 10, 38, 57, 885, DateTimeKind.Local).AddTicks(6322), "InStock", "Corrupti velit consectetur et et non eveniet. Vero dolorem eum ea. Sit doloribus sunt molestiae.", "Product 369", "S", "Footwear" },
                    { 370, new DateTime(2020, 6, 26, 10, 38, 57, 886, DateTimeKind.Local).AddTicks(550), "InStock", "Maxime ducimus harum repellat alias saepe at sed non. Natus sed fugit aut ipsam eos quae reiciendis cum. Fugit praesentium quisquam aut quibusdam sint ut. Aut temporibus magni fugiat.", "Product 370", "M", "Accessory" },
                    { 371, new DateTime(2020, 8, 5, 10, 38, 57, 886, DateTimeKind.Local).AddTicks(3491), "InStock", "Saepe ut sint quis. Aut vel mollitia et. Sit ipsum ab sed. In enim eos aspernatur porro enim esse corporis.", "Product 371", "S", "Outerwear" },
                    { 372, new DateTime(2020, 8, 28, 10, 38, 57, 886, DateTimeKind.Local).AddTicks(7038), "InStock", "Ipsa cupiditate quas dolore fugiat dolores deserunt dolores. Recusandae possimus aut molestias ea dolor consequatur deserunt facere. Soluta dolor ut provident quia cumque unde reiciendis.", "Product 372", "XS", "Footwear" },
                    { 373, new DateTime(2020, 9, 10, 10, 38, 57, 887, DateTimeKind.Local).AddTicks(2260), "InStock", "Quia ut deleniti eveniet. A fugit reprehenderit sint veniam harum voluptas inventore sunt. Qui eligendi consequatur asperiores itaque aperiam fugit dolor iusto. Iste quasi eum quo non excepturi aperiam vel enim. Dolores aut illum sequi et ut.", "Product 373", "XS", "Underwear" },
                    { 346, new DateTime(2020, 8, 22, 10, 38, 57, 873, DateTimeKind.Local).AddTicks(5691), "InStock", "Expedita placeat aut quas distinctio aut ratione consequatur. Autem quam atque consequatur fugiat molestiae. Harum architecto ullam accusamus enim hic. Ut sunt natus similique.", "Product 346", "XS", "Accessory" },
                    { 345, new DateTime(2020, 9, 8, 10, 38, 57, 873, DateTimeKind.Local).AddTicks(1045), "OutStock", "Ab et nobis maiores consequuntur id neque quam cumque. Cumque soluta accusamus alias sed. Quod est neque doloremque. Voluptas eveniet dolorem architecto sunt consequatur magni quidem. Debitis et doloremque error non.", "Product 345", "XS", "Outerwear" },
                    { 344, new DateTime(2020, 8, 7, 10, 38, 57, 872, DateTimeKind.Local).AddTicks(5072), "OutStock", "Aut sunt quo natus commodi ipsa recusandae. Quo nihil voluptatibus laboriosam dolores sapiente fuga. Consequatur culpa aut illum. Omnis quibusdam qui dolore. Amet ducimus tempore eos nesciunt asperiores.", "Product 344", "XS", "Outerwear" },
                    { 343, new DateTime(2020, 8, 5, 10, 38, 57, 871, DateTimeKind.Local).AddTicks(9681), "OutStock", "Ut laudantium praesentium provident doloribus. Ratione perferendis cum ea quam. Et culpa perferendis quia laudantium consequatur. Sequi temporibus enim quam dolor labore. Quod ut et rerum.", "Product 343", "XS", "Outerwear" },
                    { 315, new DateTime(2020, 8, 21, 10, 38, 57, 858, DateTimeKind.Local).AddTicks(557), "OutStock", "Id unde reprehenderit optio suscipit est. Fugit voluptatibus facilis in reiciendis ducimus rerum. Similique enim voluptas eos laborum enim. Similique quas reprehenderit quis ipsa quia officiis.", "Product 315", "S", "Accessory" },
                    { 316, new DateTime(2020, 7, 17, 10, 38, 57, 858, DateTimeKind.Local).AddTicks(4224), "InStock", "Ut ullam blanditiis eos. Repudiandae est atque sunt officiis. Harum sunt et hic molestias adipisci debitis accusamus illum.", "Product 316", "M", "Underwear" },
                    { 317, new DateTime(2020, 8, 13, 10, 38, 57, 858, DateTimeKind.Local).AddTicks(7796), "InStock", "Et enim iure sint. Accusantium adipisci ut est quia voluptatum. Cupiditate voluptas in mollitia et ut tempore.", "Product 317", "XS", "Footwear" },
                    { 318, new DateTime(2020, 7, 21, 10, 38, 57, 859, DateTimeKind.Local).AddTicks(1636), "OutStock", "Vel accusamus cumque aut ea sed. Dolor sed tempora sit dolorem modi explicabo odit ut. Commodi velit qui enim.", "Product 318", "L", "Footwear" },
                    { 319, new DateTime(2020, 7, 21, 10, 38, 57, 859, DateTimeKind.Local).AddTicks(7053), "InStock", "Minus ut odit et ducimus error aut. Optio minima ex et animi. At et recusandae voluptatibus expedita. Et ipsum et optio aut delectus. Veniam ducimus eveniet laudantium ut.", "Product 319", "L", "Accessory" },
                    { 320, new DateTime(2020, 6, 18, 10, 38, 57, 860, DateTimeKind.Local).AddTicks(1359), "OutStock", "Rerum incidunt corrupti facilis rem. Atque eaque quia aut omnis qui accusantium molestias et. Eos asperiores et assumenda et dolor assumenda.", "Product 320", "XS", "Accessory" },
                    { 321, new DateTime(2020, 9, 17, 10, 38, 57, 860, DateTimeKind.Local).AddTicks(5348), "OutStock", "Voluptatum beatae velit fugiat ut velit. Odio et ut qui est. Quibusdam soluta atque quis voluptatum sit et aut eveniet.", "Product 321", "XS", "Accessory" },
                    { 322, new DateTime(2020, 8, 10, 10, 38, 57, 861, DateTimeKind.Local).AddTicks(1745), "InStock", "Omnis at eos laboriosam ad et quisquam qui ipsa. Animi enim ad dolores et consectetur sed qui. Harum omnis enim assumenda sit nam magni enim molestias. Aut et mollitia et ea aperiam velit quis.", "Product 322", "XS", "Footwear" },
                    { 323, new DateTime(2020, 7, 27, 10, 38, 57, 861, DateTimeKind.Local).AddTicks(8118), "OutStock", "Quis doloremque dolorem vel aut molestiae qui adipisci eaque. Sint dolores in quibusdam nesciunt provident odio eveniet qui. Accusantium autem vel iste perferendis quis rerum rerum. Inventore voluptatum delectus libero iure iure totam optio.", "Product 323", "M", "Accessory" },
                    { 324, new DateTime(2020, 7, 30, 10, 38, 57, 862, DateTimeKind.Local).AddTicks(3389), "OutStock", "Amet eum qui ab maxime odit soluta. Libero animi blanditiis id dolores nobis perspiciatis. Inventore inventore pariatur ut tenetur ipsam reiciendis rerum. Voluptatem maxime corporis corporis eum.", "Product 324", "M", "Footwear" },
                    { 325, new DateTime(2020, 9, 17, 10, 38, 57, 862, DateTimeKind.Local).AddTicks(9176), "InStock", "Et dicta sed quae non fugit animi. Ullam doloremque officiis molestias sequi quam adipisci corrupti alias. Reprehenderit blanditiis occaecati similique error laudantium. Rerum praesentium nihil modi. Maxime aut aspernatur reprehenderit.", "Product 325", "L", "Underwear" },
                    { 326, new DateTime(2020, 8, 23, 10, 38, 57, 863, DateTimeKind.Local).AddTicks(6209), "InStock", "Rerum officiis ducimus voluptas consectetur dolorem voluptatem est. Et corrupti harum dolor minima occaecati commodi. Aut sed necessitatibus autem aut amet quis aut illo. Et voluptas consequuntur dolorem quod et. Illo temporibus voluptatibus vel quas qui earum voluptas.", "Product 326", "M", "Accessory" },
                    { 327, new DateTime(2020, 9, 13, 10, 38, 57, 863, DateTimeKind.Local).AddTicks(9941), "OutStock", "Soluta adipisci et iste quam quis dolor. Et consectetur repudiandae iste qui nam. Beatae dolorum aut odio odit.", "Product 327", "M", "Accessory" },
                    { 313, new DateTime(2020, 8, 2, 10, 38, 57, 856, DateTimeKind.Local).AddTicks(9109), "InStock", "Consequatur sapiente est rem rerum blanditiis et sed nihil. Saepe commodi aut sint et. Rerum a nobis eos laudantium similique autem aspernatur.", "Product 313", "XS", "Accessory" },
                    { 328, new DateTime(2020, 8, 15, 10, 38, 57, 864, DateTimeKind.Local).AddTicks(4300), "OutStock", "Voluptatem nihil labore enim consectetur. Inventore modi quidem ullam. Distinctio molestiae quia quae tenetur sequi quibusdam est iusto. Quis est fugiat nesciunt.", "Product 328", "M", "Footwear" },
                    { 330, new DateTime(2020, 8, 23, 10, 38, 57, 865, DateTimeKind.Local).AddTicks(1487), "OutStock", "Rem est ab architecto unde. Nesciunt aut omnis odio. Molestiae voluptatem voluptatibus dolore.", "Product 330", "S", "Footwear" },
                    { 331, new DateTime(2020, 6, 13, 10, 38, 57, 865, DateTimeKind.Local).AddTicks(7433), "InStock", "Quidem rerum est incidunt reiciendis possimus ullam doloremque. Suscipit exercitationem praesentium ipsam et consequatur et eos porro. Qui ipsa odio nobis culpa dolorum. Aut facere incidunt quam et consequatur officiis ut.", "Product 331", "XS", "Footwear" },
                    { 332, new DateTime(2020, 9, 14, 10, 38, 57, 866, DateTimeKind.Local).AddTicks(3944), "InStock", "Cum tenetur distinctio et pariatur. Laboriosam ab repudiandae ipsam perspiciatis voluptatum explicabo iusto maiores. Maxime consequatur non placeat magnam numquam sit. Doloribus ea ut doloribus. Deserunt ratione omnis nihil autem qui optio fugit voluptates.", "Product 332", "L", "Accessory" },
                    { 333, new DateTime(2020, 8, 15, 10, 38, 57, 867, DateTimeKind.Local).AddTicks(397), "OutStock", "Ducimus ut ducimus a qui perferendis. Eius doloremque amet magnam magnam consequatur. Neque quia ab voluptatem asperiores et nemo et earum. Omnis illo explicabo perspiciatis et cum officia architecto. Voluptates et ratione sed nam.", "Product 333", "S", "Underwear" },
                    { 334, new DateTime(2020, 9, 2, 10, 38, 57, 867, DateTimeKind.Local).AddTicks(5850), "InStock", "Qui voluptatem nihil est neque fugit quia. Recusandae sit veniam laboriosam cumque. Ut nobis nisi odit quaerat quisquam ad amet. Iste alias esse et. Quod esse dolore soluta.", "Product 334", "L", "Underwear" },
                    { 335, new DateTime(2020, 7, 15, 10, 38, 57, 868, DateTimeKind.Local).AddTicks(209), "OutStock", "Ut voluptatem at repudiandae omnis adipisci doloremque atque rerum. Est suscipit a illum. Distinctio nihil possimus odit voluptas totam quaerat voluptas omnis.", "Product 335", "XS", "Accessory" },
                    { 336, new DateTime(2020, 8, 6, 10, 38, 57, 868, DateTimeKind.Local).AddTicks(7150), "InStock", "Id deleniti et illo voluptas. Harum necessitatibus dolorem odio eligendi quia totam. Ullam rerum voluptates et cupiditate soluta voluptates eum omnis. Quos sed omnis ut dicta ex dignissimos fugiat voluptas. Officia error nulla sunt doloremque doloribus distinctio.", "Product 336", "S", "Outerwear" },
                    { 337, new DateTime(2020, 8, 30, 10, 38, 57, 869, DateTimeKind.Local).AddTicks(2809), "InStock", "Omnis laborum omnis accusantium magnam quaerat eaque eos. Voluptatem nihil praesentium consequatur deleniti. Cupiditate est cupiditate est inventore eaque non. Odio occaecati voluptatem at autem voluptas iusto distinctio voluptatem.", "Product 337", "M", "Accessory" },
                    { 338, new DateTime(2020, 9, 3, 10, 38, 57, 869, DateTimeKind.Local).AddTicks(6125), "OutStock", "Nulla commodi numquam incidunt corporis sed quod. Dolorem rerum et asperiores. Voluptatem neque porro et quos.", "Product 338", "XS", "Outerwear" },
                    { 339, new DateTime(2020, 7, 30, 10, 38, 57, 870, DateTimeKind.Local).AddTicks(140), "InStock", "Quo fuga et esse doloribus. Illum omnis inventore aliquid occaecati tenetur. Eos molestiae deleniti iure sit illum rem voluptatum nisi.", "Product 339", "M", "Outerwear" },
                    { 340, new DateTime(2020, 7, 5, 10, 38, 57, 870, DateTimeKind.Local).AddTicks(3772), "InStock", "Numquam voluptate libero sint perferendis animi modi sed. Voluptatem iure labore quia. Omnis facilis cumque dolorum quasi amet.", "Product 340", "XS", "Accessory" },
                    { 341, new DateTime(2020, 6, 28, 10, 38, 57, 870, DateTimeKind.Local).AddTicks(8408), "InStock", "Sint et assumenda voluptate quisquam pariatur ea est. Voluptas ad consequatur exercitationem nemo ipsum voluptatem vel voluptatem. Nostrum autem consectetur nihil aliquam est quod.", "Product 341", "S", "Accessory" },
                    { 342, new DateTime(2020, 8, 30, 10, 38, 57, 871, DateTimeKind.Local).AddTicks(4527), "InStock", "Cum culpa enim porro in occaecati consequatur. Nihil nemo autem quidem. Porro hic qui est facilis tempore architecto ullam ipsa. Modi vel voluptas voluptate ipsum. Ut laboriosam id iure ea vel voluptatem.", "Product 342", "M", "Underwear" },
                    { 329, new DateTime(2020, 7, 17, 10, 38, 57, 864, DateTimeKind.Local).AddTicks(8244), "OutStock", "Tenetur et et et. Cumque natus optio iste odit. Sunt blanditiis rerum saepe ratione repellat. Facilis architecto quaerat provident laudantium.", "Product 329", "L", "Accessory" },
                    { 1000, new DateTime(2020, 7, 6, 10, 38, 58, 91, DateTimeKind.Local).AddTicks(8105), "OutStock", "Aut dolore vero tempore unde. A dicta qui non labore saepe. Voluptatem reiciendis soluta sit debitis qui quia delectus.", "Product 1000", "S", "Outerwear" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1000);
        }
    }
}
