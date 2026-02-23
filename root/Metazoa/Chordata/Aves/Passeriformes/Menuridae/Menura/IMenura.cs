namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Menuridae.Menura;

/// <summary>
/// Interface defining characteristics of Menura (genus).
/// </summary>
public interface IMenura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
