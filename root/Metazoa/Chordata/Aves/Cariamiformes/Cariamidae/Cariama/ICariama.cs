namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cariamiformes.Cariamidae.Cariama;

/// <summary>
/// Interface defining characteristics of Cariama (genus).
/// </summary>
public interface ICariama
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
