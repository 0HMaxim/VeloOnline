using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models
{
    public class TestData
    {
        public static void Initialize(BikeContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!context.Bicycles.Any())
            {
                context.Bicycles.AddRange(
                new Bike
                {
                    Title = "Ardis Corsair AMT 26 / рама 17",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                    Description = @"Стильный и привлекающий к себе внимание велосипед Cannondale BAD BOY 3 создан для активной езды по городу. Лёгкий и мобильный, такой байк идеален в условиях загруженных улиц. Проскочить между припаркованными машинами, маневрировать на узкой улочке, преодолеть неровное дорожное покрытие и разогнаться на свободной трассе - с BAD BOY возможно всё!",
                    Manufacturer = "Marin Four Corners",
                    WheelSize = 26,
                    Price = 10500,
                    NumberOfSpeeds = 24,
                    Weight = 14.3,
                },
               new Bike
               {
                   Title = "Ardis Laser АМТ 26",
                   ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                   Description = @"Стильный и привлекающий к себе внимание велосипед Cannondale BAD BOY 3 создан для активной езды по городу. Лёгкий и мобильный, такой байк идеален в условиях загруженных улиц. Проскочить между припаркованными машинами, маневрировать на узкой улочке, преодолеть неровное дорожное покрытие и разогнаться на свободной трассе - с BAD BOY возможно всё!",
                   Manufacturer = "Marin Four Corners",
                   WheelSize = 26,
                   Price = 6375,
                   NumberOfSpeeds = 21,
                   Weight = 16.5,
               },
                new Bike
                {
                    Title = "Ardis Corsair AMT 26 / рама 17",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3fa8056a831c8478a09776b156820907.jpg",
                    Description = "Cannondale F-Si Carbon 4 – это гоночный байк обладающий невероятной динамичностью и управляемостью. Будь то марафон, кросс-кантрийный чемпионат или же просто тренировка, F-Si каждый раз провоцирует райдера бросать вызов соперникам и самому себе.",
                    Manufacturer = "Marin Four Corners",
                    WheelSize = 26,
                    Price = 10500,
                    NumberOfSpeeds = 24,
                    Weight = 16.7,
                },
                new Bike
                {
                    Title = "Crossride FREESTYLE ST",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3fa8056a831c8478a09776b156820907.jpg",
                    Description = "Cannondale F-Si Carbon 4 – это гоночный байк обладающий невероятной динамичностью и управляемостью. Будь то марафон, кросс-кантрийный чемпионат или же просто тренировка, F-Si каждый раз провоцирует райдера бросать вызов соперникам и самому себе.",
                    Manufacturer = "Marin Four Corners",
                    WheelSize = 20,
                    Price = 4088,
                    NumberOfSpeeds = 1,
                    Weight = 16,
                },
                new Bike
                {
                    Title = "Велосипед 29 Orbea ALMA H50",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/f59a3b425564d108a74e3450c82dc3d2.jpg",
                    Description = @"Стильный и привлекающий к себе внимание велосипед Cannondale BAD BOY 3 создан для активной езды по городу. Лёгкий и мобильный, такой байк идеален в условиях загруженных улиц. Проскочить между припаркованными машинами, маневрировать на узкой улочке, преодолеть неровное дорожное покрытие и разогнаться на свободной трассе - с BAD BOY возможно всё!",
                    Manufacturer = "Marin Four Corners",
                    WheelSize = 29,
                    Price = 35532,
                    NumberOfSpeeds = 11,
                    Weight = 12.9,
                },
                new Bike
                {
                    Title = "Велосипед 29 Merida Big Nine 600",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/f59a3b425564d108a74e3450c82dc3d2.jpg",
                    Description = "Cannondale F-Si Carbon 4 – это гоночный байк обладающий невероятной динамичностью и управляемостью. Будь то марафон, кросс-кантрийный чемпионат или же просто тренировка, F-Si каждый раз провоцирует райдера бросать вызов соперникам и самому себе.",
                    Manufacturer = "Marin Four Corners",
                    WheelSize = 26,
                    Price = 41391,
                    NumberOfSpeeds = 12,
                    Weight = 12.18,
                },
                new Bike
                {
                    Title = "Велосипед 26 Leon HT LADY модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                    Description = "Велосипеды из модельного ряда Cannondale Trail идеально подходят для езды по пересечённой местности, как для новичка, так и для более продвинутого велосипедиста. А их модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела.",
                    Manufacturer = "Wahoo",
                    WheelSize = 26,
                    Price = 10935,
                    NumberOfSpeeds = 24,
                    Weight = 13.7,
                },
                new Bike
                {
                    Title = "Велосипед 27,5 Leon XC - 90",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3fa8056a831c8478a09776b156820907.jpg",
                    Description = "Cannondale F-Si Carbon 4 – это гоночный байк обладающий невероятной динамичностью и управляемостью. Будь то марафон, кросс-кантрийный чемпионат или же просто тренировка, F-Si каждый раз провоцирует райдера бросать вызов соперникам и самому себе.",
                    Manufacturer = "Marin Four Corners",
                    WheelSize = 27,
                    Price = 12096,
                    NumberOfSpeeds = 24,
                    Weight = 15.1,
                },
                new Bike
                {
                    Title = "Велосипед 24 Leon JUNIOR AM Vbr",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/f59a3b425564d108a74e3450c82dc3d2.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 24,
                    Price = 7668,
                    NumberOfSpeeds = 7,
                    Weight = 12.1,
                },
                new Bike
                {
                    Title = "Велосипед 28 Fuji JARI 2.3 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/6956cbcf35e30a32e46940d3adb70c10.jpg",
                    Description = @"Велосипеды из модельного ряда Cannondale Trail идеально подходят для езды по пересечённой местности, как для новичка, так и для более продвинутого велосипедиста.
                    Алюминиевая рама изготовлена из лёгкого и прочного фирменного сплава SmartForm C3 с применением уникальной технологии гашения вибрации SAVE разработанной Cannondale.Современная геометрия рамы с длинным и низким передним треугольником,
                    короткими перьями и более острым углом рулевого стакана,
                    делают велосипед устойчивым как на плоской поверхности,
                    так и на спусках,
                    позволяя ему оставаться динамичным при ускорениях и при езде в гору.
                    Амортизационная вилка SR Suntour XCT с ходом 100 мм и широкие покрышки 2,
                    25’’ обеспечивают отличное сцепление на бездорожье,
                    а гидравлические дисковые тормоза Shimano MT200 дают превосходный контроль над усилием нажатия тормозной ручки,
                    делая торможение более эффективным.На велосипеде установлена трансмиссия начального уровня Shimano / microSHIFT 2х8 с индикаторами текущей включенной передачи на ручках переключения.
                    Cannondale Trail 7 – отличный выбор для любителей велопрогулок подальше от городского асфальта и бетона,
                    а так же для тех,
                    кто только начинает знакомиться с велосипедным миром.",
                    Manufacturer = "Wahoo",
                    WheelSize = 28,
                    Price = 33299,
                    NumberOfSpeeds = 218,
                    Weight = 12.03,
                },
                new Bike
                {
                    Title = "Велосипед 27.5 Kinetic Vesta",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3fa8056a831c8478a09776b156820907.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме, модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела",
                    Manufacturer = "Wahoo",
                    WheelSize = 27,
                    Price = 8352,
                    NumberOfSpeeds = 21,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед Kinetic Profi",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                    Description = "Велосипеды из модельного ряда Cannondale Trail идеально подходят для езды по пересечённой местности, как для новичка, так и для более продвинутого велосипедиста. А их модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 26,
                    Price = 8149,
                    NumberOfSpeeds = 21,
                    Weight = 13.2,
                },
                new Bike
                {
                    Title = "Велосипед 29 Kinetic Storm",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3d96ceb71a5e322c1a509c52fffe2d11.jpg",
                    Description = "Cannondale F-Si Carbon 4 – это гоночный байк обладающий невероятной динамичностью и управляемостью. Будь то марафон, кросс-кантрийный чемпионат или же просто тренировка, F-Si каждый раз провоцирует райдера бросать вызов соперникам и самому себе.",
                    Manufacturer = "CANNONDALE",
                    WheelSize = 29,
                    Price = 8613,
                    NumberOfSpeeds = 21,
                    Weight = 14.5,
                },
                new Bike
                {
                    Title = "Велосипед 28 Cannondale TOPSTONE 4",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/321165e2a1d50429997e5d219d27733a.jpg",
                    Description = "Велосипеды из модельного ряда Cannondale Trail идеально подходят для езды по пересечённой местности, как для новичка, так и для более продвинутого велосипедиста. А их модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 28,
                    Price = 31871,
                    NumberOfSpeeds = 10,
                    Weight = 10.3,
                },
                new Bike
                {
                    Title = "Велосипед 28 Cannondale TOPSTONE 3",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3d96ceb71a5e322c1a509c52fffe2d11.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме, модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела",
                    Manufacturer = "CANNONDALE",
                    WheelSize = 28,
                    Price = 37091,
                    NumberOfSpeeds = 18,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Ardis Corsair AMT 26 / рама 17",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3d96ceb71a5e322c1a509c52fffe2d11.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме, модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 26,
                    Price = 10500,
                    NumberOfSpeeds = 24,
                    Weight = 10.3,
                },
                new Bike
                {
                    Title = "Велосипед 24 Leon JUNIOR AM Vbr",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме, модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела",
                    Manufacturer = "CANNONDALE",
                    WheelSize = 24,
                    Price = 7668,
                    NumberOfSpeeds = 7,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед 28 Marin NICASIO",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/64bc2010625cc803cdb428b0a9609dde.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме, модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 28,
                    Price = 22881,
                    NumberOfSpeeds = 16,
 
                    Weight = 12.3,
                },
                new Bike
                {
                    Title = "Велосипед 27.5 Marin NICASIO + ",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/295a52a03d64dac12ecd623c97e53128.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме.",
                    Manufacturer = "Lezyne",
                    WheelSize = 27,
                    Price = 24911,
                    NumberOfSpeeds = 9,
                    Weight = 11.08,
                },
                new Bike
                {
                    Title = "Велосипед 27.5 Leon XC - LADY модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/321165e2a1d50429997e5d219d27733a.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 27,
                    Price = 12258,
                    NumberOfSpeeds = 24,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед 28 Orbea Carpe 40",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/295a52a03d64dac12ecd623c97e53128.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме, модификация Feminine, предназначенная для девушек, создавалась с учётом физиологических и анатомических особенностей строения женского тела",
                    Manufacturer = "Lezyne",
                    WheelSize = 28,
                    Price = 21308,
                    NumberOfSpeeds = 7,
                    Weight = 11.3,
                },
                new Bike
                {
                    Title = "Велосипед 28 Marin GESTALT",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/64bc2010625cc803cdb428b0a9609dde.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 28,
                    Price = 26071,
                    NumberOfSpeeds = 16,
                    Weight = 10,
                },
                new Bike
                {
                    Title = "Велосипед 27.5 Pride ROCKSTEADY 7.1",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/3d96ceb71a5e322c1a509c52fffe2d11.jpg",
                    Description = @"Велосипеды из модельного ряда Cannondale Trail идеально подходят для езды по пересечённой местности, как для новичка, так и для более продвинутого велосипедиста.
                    Алюминиевая рама изготовлена из лёгкого и прочного фирменного сплава SmartForm C3 с применением уникальной технологии гашения вибрации SAVE разработанной Cannondale.Современная геометрия рамы с длинным и низким передним треугольником,
                    короткими перьями и более острым углом рулевого стакана,
                    делают велосипед устойчивым как на плоской поверхности,
                    так и на спусках,
                    позволяя ему оставаться динамичным при ускорениях и при езде в гору.",
                    Manufacturer = "CANNONDALE",
                    WheelSize = 27,
                    Price = 10991,
                    NumberOfSpeeds = 21,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед 27.5 Leon XC - LADY модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/af4c7667091f9d16d7f541d3c62b5b79.jpg",
                    Description = @"Велосипеды из модельного ряда Cannondale Trail идеально подходят для езды по пересечённой местности, как для новичка, так и для более продвинутого велосипедиста.
                    Алюминиевая рама изготовлена из лёгкого и прочного фирменного сплава SmartForm C3 с применением уникальной технологии гашения вибрации SAVE разработанной Cannondale.Современная геометрия рамы с длинным и низким передним треугольником,
                    короткими перьями и более острым углом рулевого стакана,
                    делают велосипед устойчивым как на плоской поверхности,
                    так и на спусках,
                    позволяя ему оставаться динамичным при ускорениях и при езде в гору.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 27,
                    Price = 12258,
                    NumberOfSpeeds = 24,
                    Weight = 14.6,
                },
                new Bike
                {
                    Title = "Велосипед 20 Dorozhnik Onyx",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/af4c7667091f9d16d7f541d3c62b5b79.jpg",
                    Description = "Cannondale Trail SL – это долгожданное возвращение флагманского алюминиевого хардтейла в линейке производителя. Имея общую геометрию с Cannondale Trail, модель с индексом SL построена на обновлённой более лёгкой и технологичной раме.",
                    Manufacturer = "GIANT",
                    WheelSize = 20,
                    Price = 6685,
                    NumberOfSpeeds = 7,
                    Weight = 14,
                },
                new Bike
                {
                    Title = "Велосипед Dorozhnik LUX 26 PH модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/321165e2a1d50429997e5d219d27733a.jpg",
                    Description = "Новый Cannondale Scalpel 2021-го года серии SE (Special Edition) — это идеальный аппарат для кросс-кантри и марафонов, а также надёжный вариант для трейла. Скорости",
                    Manufacturer = "GIANT",
                    WheelSize = 26,
                    Price = 6969,
                    NumberOfSpeeds = 3,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед Dorozhnik LUX 26 Vbr модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                    Description = "Новый Cannondale Scalpel 2021-го года серии SE (Special Edition) — это идеальный аппарат для кросс-кантри и марафонов, а также надёжный вариант для трейла. Скорости",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 26,
                    Price = 5685,
                    NumberOfSpeeds = 1,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед Merida Silex 4000",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/295a52a03d64dac12ecd623c97e53128.jpg",
                    Description = "Новый Cannondale Scalpel 2021-го года серии SE (Special Edition) — это идеальный аппарат для кросс-кантри и марафонов, а также надёжный вариант для трейла. Скорости",
                    Manufacturer = "GIANT",
                    WheelSize = 28,
                    Price = 63369,
                    NumberOfSpeeds = 20,
                    Weight = 8.93,
                },
                new Bike
                {
                    Title = "Велосипед Merida SPEEDER 100",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/af4c7667091f9d16d7f541d3c62b5b79.jpg",
                    Description = "Новый Cannondale Scalpel 2021-го года серии SE (Special Edition) — это идеальный аппарат для кросс-кантри и марафонов, а также надёжный вариант для трейла. Скорости",
                    Manufacturer = "GIANT",
                    WheelSize = 28,
                    Price = 20385,
                    NumberOfSpeeds = 24,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "Велосипед 27,5 Fuji NEVADA 1.9 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/08b208d1d4c7375c9f8f3ace528c802c.png",
                    Description = "Тяжело найти более популярную линейку в нашем ассортименте, чем гравийники Rocx. Гравийники покупают из-за их универсальности, возможности проехать как по пересечнной местности, так и по асфальту. По сути под ваши собственные задачи велосипед можно адаптировать простой заменой покрышек.",
                    Manufacturer = "GIANT",
                    WheelSize = 27,
                    Price = 14899,
                    NumberOfSpeeds = 21,
                    Weight = 14.3,
                },
                new Bike
                {
                    Title = "BMX Street Cro-Mo модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/main/321165e2a1d50429997e5d219d27733a.jpg",
                    Description = "Тяжело найти более популярную линейку в нашем ассортименте, чем гравийники Rocx. Гравийники покупают из-за их универсальности, возможности проехать как по пересечнной местности, так и по асфальту. По сути под ваши собственные задачи велосипед можно адаптировать простой заменой покрышек.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 20,
                    Price = 13282,
                    NumberOfSpeeds = 1,
                    Weight = 11,
                },
                new Bike
                {
                    Title = "BMX Street Hi Ten модель 2021",
                    ImageUrl = "https://velogo.com.ua/uploads/shop/products/large/41cf519bba28ae9b23a99863584a7943.jpg",
                    Description = "Тяжело найти более популярную линейку в нашем ассортименте, чем гравийники Rocx. Гравийники покупают из-за их универсальности, возможности проехать как по пересечнной местности, так и по асфальту. По сути под ваши собственные задачи велосипед можно адаптировать простой заменой покрышек.",
                    Manufacturer = "Pride ROCX",
                    WheelSize = 20,
                    Price = 11484,
                    NumberOfSpeeds = 1,
                    Weight = 10.3,
                });

                context.SaveChanges();

                if (!userManager.Users.Any())
                {
                    User user = new User { UserName = "admin@gmail.com" };


                    Task.Run(() => userManager.CreateAsync(user, "Qwerty_1")).Wait();


                    Task.Run(() => Create("admin", roleManager)).Wait();
                    Task.Run(() => Create("user", roleManager)).Wait();


                    var admin = userManager.FindByNameAsync("admin@gmail.com").Result;

                   
                    Task.Run(() => userManager.AddToRoleAsync(admin, "admin")).Wait();
                }

            }

        }
        public static async Task<int> Create(string name, RoleManager<IdentityRole> roleManager)
        {
            IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
            return 0;
        }
    }
}
