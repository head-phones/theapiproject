
$(function () {
    'use strict'

    $('[data-toggle="offcanvas"]').on('click', function () {
        $('.offcanvas-collapse').toggleClass('open')
    })
    feather.replace()
})

$(function () {
    InitHeader()
    InitFooter()
})
function InitFooter() {
    var hfooter = $('footer').height()
    $('main').css('padding-bottom', hfooter + 'px')
}
function InitHeader() {
    var navHeight = $('.navbar').outerHeight()
    $('body').attr('style', 'padding-top:' + navHeight + 'px !important')
    $('.offcanvas-collapse').attr('style', 'top: ' + navHeight + 'px !important')
}