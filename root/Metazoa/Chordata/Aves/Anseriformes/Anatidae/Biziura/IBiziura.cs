namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Biziura;

/// <summary>
/// Interface defining characteristics of Biziura (genus).
/// </summary>
public interface IBiziura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
