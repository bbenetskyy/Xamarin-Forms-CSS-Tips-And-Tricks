var gulp = require("gulp"),
    less = require("gulp-less");
var styleFolderPath = "../CSS.Sample/CSS.Sample/Styles/";

gulp.task('less', function () {
    return gulp.src([styleFolderPath + '!Colors.less', styleFolderPath + '*.less'])
        .pipe(less())
        .pipe(gulp.dest(styleFolderPath + 'css'));
});

gulp.task('watch', function () {
    gulp.watch(styleFolderPath + '*.less', ['less']);
});

gulp.task('default', ['less', 'watch']);