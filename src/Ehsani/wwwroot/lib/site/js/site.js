// jQuery for page scrolling feature - requires jQuery Easing plugin
$(function () {
    $('a.page-scroll').bind('click', function (event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });
    var gasp = new JustGage({
        id: "skill-asp",
        value: 0,
        min: 0,
        max: 100,
        title: ".Net",
        label: "%"
    });

    $(window).scroll(function () {
        var windowScrollTop = $(this).scrollTop();
        var pos = $("#keyskills").offset().top;
        if (windowScrollTop >= pos) {
            gasp.refresh(99);
        }
    });
});

// Highlight the top nav as scrolling occurs
$('body').scrollspy({
    target: '.navbar-fixed-top'
})

// Closes the Responsive Menu on Menu Item Click
$('.navbar-collapse ul li a').click(function () {
    $('.navbar-toggle:visible').click();
});