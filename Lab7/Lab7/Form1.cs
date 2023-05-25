using System.Numerics;

namespace Lab7;

public partial class Form1 : Form {
    private const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    private BigInteger _p;
    private BigInteger _g;
    private BigInteger _y;
    private BigInteger _ock;
    private BigInteger _w;
    private BigInteger _k;
    private BigInteger _kReverse;

    private BigInteger _x;

    public Form1() {
        InitializeComponent();
    }

    private void BtnDecrypt_Click(object sender, EventArgs e) {
        txtResult.Text = string.Empty;

        if (!Init()) {
            return;
        }

        var decryptResult = Decrypt();
        txtResult.Text =
            "x = " + _x.ToString() +
            "; k = " + _k +
            "; k^-1 = " + _kReverse +
            "; c = " + decryptResult.ToString() + " = " + NumberToText(decryptResult);
    }

    private bool Init() {
        var valid = true;
        if (!BigInteger.TryParse(textP.Text, out _p)) {
            valid = false;
        }
        if (!BigInteger.TryParse(textG.Text, out _g)) {
            valid = false;
        }
        if (!BigInteger.TryParse(textY.Text, out _y)) {
            valid = false;
        }
        if (!BigInteger.TryParse(textOck.Text, out _ock)) {
            valid = false;
        }
        if (!BigInteger.TryParse(textW.Text, out _w)) {
            valid = false;
        }

        if (!valid) {
            MessageBox.Show("Не все инициализировано", "Ошибка!", MessageBoxButtons.OK);
        }

        return valid;
    }

    private BigInteger Decrypt() {
        InitX();
        _k = BigInteger.ModPow(_ock, _x, _p);
        _kReverse = MathUtils.ExtendedGcd(_p, _k).t;

        return (_w * _kReverse) % _p;
    }

    private static string NumberToText(BigInteger number) {
        var numberStr = number.ToString();
        if (numberStr.Length % 2 != 0) {
            numberStr = "0" + numberStr;
        }

        var result = string.Empty;
        for (var i = 0; i < numberStr.Length - 1; i += 2) {
            var index = Convert.ToInt32(numberStr.Substring(i, 2));
            result += ALPHABET[index - 1];
        }

        return result;
    }

    private BigInteger InitX() {
        _x = BigInteger.One;
        while (BigInteger.ModPow(_g, _x, _p) != _y) {
            _x++;
        }

        return _x;
    }
}