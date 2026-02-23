namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Myrmecophagidae.Tamandua;

/// <summary>
/// Interface defining characteristics of Tamandua (genus).
/// </summary>
public interface ITamandua
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
