@Yahoo
Feature: Yahoo
	Simple checking Yahoo using Chrome

Scenario Outline: Check if title or img has changed
	When user check the web
	Then the title should be <Title>
	And the img url should be <Img>

Examples:
| Title																																				 | Img																																														|
| Hacker tìm ra bằng chứng 'tuyệt mật' liên quan vụ 13 tỷ, giúp bà Phương Hằng tung 'đòn chí mạng', gây náo l.o.ạ.n showbiz Việt vài ngày qua là ai? | https://s.yimg.com/uu/api/res/1.2/D7oADB6LVIfwIq1Xkc.pyw--~B/Zmk9c3RyaW07aD0yNDY7cT04MDt3PTQ0MDthcHBpZD15dGFjaHlvbg--/https://s.yimg.com/am/60d/146463abb3d7332b17d49121d07cafbb.cf.webp	|
| Anh trai tôi ly hôn vì vợ vô sinh, 4 năm sau chị dâu cũ về quê đi ngang qua cửa nhà mà khiến cả gia đình tôi 'hóa đá'								 | https://s.yimg.com/uu/api/res/1.2/0.UdsmSorXcRQPrJZsBruQ--~B/Zmk9c3RyaW07aD0yNDY7cT04MDt3PTQ0MDthcHBpZD15dGFjaHlvbg--/https://s.yimg.com/am/60d/84d814fbb819314f7a9b34179e8fb4b1.cf.webp	|
| Đam mê trò chơi 'đổi vợ đổi chồng', người đàn ông ra sức thuyết phục vợ nhập hội và nhận cái kết cay đắng											 | https://s.yimg.com/uu/api/res/1.2/fFwki7neqrZ1LV7jzak__A--~B/Zmk9c3RyaW07aD0yNDY7cT04MDt3PTQ0MDthcHBpZD15dGFjaHlvbg--/https://s.yimg.com/am/60d/ce669a025edd077d8606537a9eaa8a4b.cf.webp	|