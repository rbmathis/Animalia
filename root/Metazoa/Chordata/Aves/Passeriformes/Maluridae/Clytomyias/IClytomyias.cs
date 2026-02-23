namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Clytomyias;

/// <summary>
/// Interface defining characteristics of Clytomyias (genus).
/// </summary>
public interface IClytomyias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
