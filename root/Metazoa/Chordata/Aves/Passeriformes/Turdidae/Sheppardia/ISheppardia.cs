namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Sheppardia;

/// <summary>
/// Interface defining characteristics of Sheppardia (genus).
/// </summary>
public interface ISheppardia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
