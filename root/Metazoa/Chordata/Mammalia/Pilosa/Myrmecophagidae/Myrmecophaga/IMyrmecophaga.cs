namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae.Myrmecophaga;

/// <summary>
/// Interface defining characteristics of Myrmecophaga (genus).
/// </summary>
public interface IMyrmecophaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
