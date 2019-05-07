var gulp = require("gulp"),
    less = require("gulp-less");

gulp.task('less', function () {
    return gulp.src(['./Styles/!Colors.less', './Styles/*.less'])
        .pipe(less())
        .pipe(gulp.dest('./Styles/css'));
});

gulp.task('watch', function () {
    gulp.watch('./Styles/*.less', ['less']);
});

gulp.task('default', ['less', 'watch']);