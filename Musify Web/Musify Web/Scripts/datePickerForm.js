$(function () {
    var dp = $('#inputDate');

    dp.datetimepicker({
        format: "YYYY/MM/DD"
    });

    dp.on('changeDate', function (e) {
        var mDate = new moment(e.date);
        $("input", dt).attr('value', mDate.format('YYYY/MM/DD'));
    });
});