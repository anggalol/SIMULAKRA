using System;
using SSELib.AnswerKey;

namespace SSELib.Question
{
    /// <summary>
    /// Mendefinisikan sifat suatu tipe pertanyaan berdasarkan jenis soalnya.
    /// </summary>
    public interface IQuestion
    {
        /// <summary>
        /// Banyaknya opsi jawaban yang merentang dari sumbu-x dan sumbu-y.
        /// </summary>
        Options AnswerOptions { get; }

        /// <summary>
        /// Banyaknya opsi yang harus dijawab oleh peserta.
        /// </summary>
        int MustAnsweredOptions { get; }

        /// <summary>
        /// Sumbu acuan yang digunakan untuk mengoreksi jawaban peserta.
        /// </summary>
        BaseAxis BaseAxis { get; }

        /// <summary>
        /// Skor untuk soal.
        /// </summary>
        float Score { get; set; }

        /// <summary>
        /// Apakah soal menggunakan audio sebagai referensinya. Biasanya untuk soal listening bahasa inggris.
        /// </summary>
        bool UsingAudio { get; }

        /// <summary>
        /// Teks-teks yang ada pada opsi jawaban. Ingat bahwa banyaknya teks harus sama dengan
        /// <see cref="MustAnsweredOptions"/>.
        /// </summary>
        string[,] OptionsText { get; }

        /// <summary>
        /// Kunci jawaban yang digunakan untuk mengoreksi jawaban peserta.
        /// </summary>
        AnswerKeys AnswerKeys { get; set; }

        /// <summary>
        /// Tipe kelas jawaban yang digunakan untuk menuliskan jawaban peserta.
        /// </summary>
        Type AnswersType { get; }

        // implementasikan AnswerBox disini
    }
}
