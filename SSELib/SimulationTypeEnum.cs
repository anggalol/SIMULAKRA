using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSELib
{
    /// <summary>
    /// Enumerasi tipe simulasi. Penilaian dari setiap tipe simulasi ini berbeda dan bergantung pada tipe soal.
    /// </summary>
    public enum SimulationType
    {
        /// <summary>
        /// Tipe simulasi Ujian Nasional Berbasis Komputer (UNBK). Tipe simulasi ini hanya boleh menggunakan tipe soal
        /// pilihan ganda (biasa, kausalitas, kompleks) dan isian singkat. Perhatikan bahwa tipe simulasi ini sudah
        /// diganti dengan Asesmen Kompetensi Minimum (AKM). Nilai maksimum simulasi tipe ini adalah 100.
        /// </summary>
        [Obsolete("Use AKM instead.")]
        UNBK = 0,

        /// <summary>
        /// Tipe simulasi Asesmen Kompetensi Minimum (AKM). Tipe simulasi ini boleh menggunakan seluruh tipe soal yang
        /// ada. Nilai maksimum simulasi tipe ini adalah 100.
        /// </summary>
        AKM = 1,

        /// <summary>
        /// Tipe simulasi Ujian Tulis Berbasis Komputer (UTBK). Tipe simulasi ini hanya boleh menggunakan tipe soal
        /// pilihan ganda (biasa, kausalitas, kompleks). Penilaian tipe simulasi UTBK ini mengikuti Teori Respon Butir.
        /// </summary>
        UTBK = 2,

        /// <summary>
        /// Tipe simulasi kostum. Tipe simulasi ini boleh menggunakan seluruh tipe soal yang ada. Penilaian tipe ini
        /// juga sangat fleksibel.
        /// </summary>
        Custom = 3
    }
}
