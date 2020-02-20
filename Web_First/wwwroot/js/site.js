// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//function show() {
//    var a = document.getElementById("demo1").innerHTML;
//    var b = document.getElementById("demo2").innerHTML;
//    var c = document.getElementById("demo3").innerHTML;
//    var d = document.getElementById("demo4").innerHTML;
//    var e = document.getElementById("terms");
//    var f = document.getElementById("ttt1");
//    var g = document.getElementById("signup-form");
//    if (e.checked == true) {
//        if (a.length === 0 && b.length === 0 && c.length === 0 && d.length === 0) {
//            alert("Đăng ký tài khoản thành công !");
//            g.style.opacity = "0";
//            f.style.opacity = "1";
//            f.style.zIndex = "10";
//        }


//function 1show_2() {
//    var a = document.getElementById("pk");
//    var b = document.querySelectorAll(".pk_1");
//    // alert(a.id);
//    //alert(b);
//    //  alert(b.length);
//    var c = document.querySelectorAll(".hide_s");

//    for (var g of c)
//        g.style.opacity = "0";
//    a.style.opacity = "1";
//    for (var p of b)
//        p.style.opacity = "1"
//}
function show_scroll() {
    var a = document.getElementById("scroll-menu");
    var b = document.getElementById("simg");
    var c = document.getElementById("s1");
    //  alert("haha");
    /*.scroll-menu {
    position: fixed;
    left: 0;
    right: 0;
    margin: 0 auto;
    z-index: 999;
    transition: all 500ms linear;
    height:5rem;
    }*/
    a.style.position = "fixed";
    a.style.left = "0";
    a.style.right = "0";
    a.style.margin = "0 auto";
    a.style.zIndex = "999";
    a.style.top = "0";
    a.style.transition = "all 500ms linear";
    a.style.height = "5rem";
    b.style.height = "5rem";
    c.style.height = "5rem";
    //   alert("haha");
}
//jQuery(document).ready(function ($) {
//    //selector đến menu cần làm việc
//    var TopFixMenu = $(".navbar");
//    var pp = $(".navbar").scrollTop();
//    TopFixMenu.scrollTop(250);
//    // dùng sự kiện cuộn chuột để bắt thông tin đã cuộn được chiều dài là bao nhiêu.
//    $(window).scroll(function () {
//        // Nếu cuộn được hơn 150px rồi
//        if ($(this).scrollTop()>500) {
//            // Tiến hành show menu ra  
//            //  TopFixMenu.show();
//            alert(pp);
//        } else {
//            // Ngược lại, nhỏ hơn 150px thì hide menu đi.  
//            alert("dsad");//    TopFixMenu.hide();
//        }
//    }
//  )
//})
$(document).ready(function () {
    $(window).scroll(function (event) {
        //h_img
        var pos_body = $("html,body").scrollTop();
        console.log(pos_body);
        //  $(".scroll-menu").addClass("co-dinh-menu");
        if (pos_body > 129) {
            $(".scroll-menu").addClass("co-dinh-menu");
            $("#s1").addClass("h_img");
            $(".menu_Ao_list").addClass("menu1");
        }
        else {
            $(".scroll-menu").removeClass("co-dinh-menu");
            $("#s1").removeClass("h_img");
            $(".menu_Ao_list").removeClass("menu1");
        }

        if (pos_body > 569) {
            $('.back-to-top').addClass('back-top-hide');
        }
        else {
            $('.back-to-top').removeClass('back-top-hide');
        }
    });
    $('.back-to-top').click(function (event) {
        $('html,body').animate({ scrollTop: 0 }, 1400);
    });
});
$(document).ready(function () {
    $(".carousel").carousel();
});
$(document).ready(function () {
    $(".demo").owlCarousel({
        items: 1,
        lazyLoad: true,
        navigation: true
    });
});
$('.carousel').carousel();
$(document).ready(function () {
    $(window).scroll(function (event) {
        var pos_body = $("html,body").scrollTop();
        if (pos_body > 165) {
            $(".t111").addClass("t22");
            $(".t222").addClass("t11");
            $(".t333").addClass("t33");
            $(".t444").addClass("t44");
        }
        else {
            $(".t111").removeClass("t22");
            $(".t222").removeClass("t11");
            $(".t333").removeClass("t33");
            $(".t444").removeClass("t44");
        }
    });
});
//$(document).ready(function () {
//    $("picture").hover(function (event) {
//        $("picture").addClass("hide_pt");
//        $("picture:nth-of-type(2)").css("opacity, 1");
//        $("picture:nth-of-type(2)").css(" visibility,visible");
//    });

//});
//$(document).ready(function () {
//    $("picture").hover(function () {
//        //$("picture").css("opacity, 1");
//        //$("picture").css(" visibility,visible");
//        $("picture:nth-of-type(2)").css("opacity", "1");
//        $("picture:nth-of-type(2)").css("visibility", "visible");
//    }, function () {
//        $("picture:nth-of-type(2)").css("opacity", "0");
//        $("picture:nth-of-type(2)").css("visibility", "hidden");
//    });
//});

//$("picture").hover(
//    function () {
//        $("picture:nth-of-type(2)").addClass("hide_pt");
//    }, function () {
//        $("picture:nth-of-type(2)").removeClass("hide_pt");
//    }
//);
$('.dropdown-item').click(function () {
    var name = $(this).text();
    $('.dropdown-toggle').text(""+name+"");
})



