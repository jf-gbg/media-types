using MediaTypes;
namespace MediaTypesTests;

public class MediaFileTests
{

    [Fact]
    public void GifFileReturnsGifMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.gif");
        string expected = "image/gif";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void JpgFileReturnsJpegMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.jpg");
        string expected = "image/jpeg";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void JpegFileReturnsJpegMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.jpeg");
        string expected = "image/jpeg";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void PngFileReturnsPngMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.png");
        string expected = "image/png";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void PdfFileReturnsPdfMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.pdf");
        string expected = "application/pdf";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void ZipFileReturnsZipMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.zip");
        string expected = "application/zip";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TxtFileReturnsTxtMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.txt");
        string expected = "text/plain";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void OtherFilesReturnDefaultMIMEType()
    {
        //Arrange
        MediaFile testFile = new MediaFile("test.exe");
        string expected = "application/octet-stream";

        //Act
        string actual = testFile.GetMIMEType();

        //Assert
        Assert.Equal(actual, expected);
    }
}