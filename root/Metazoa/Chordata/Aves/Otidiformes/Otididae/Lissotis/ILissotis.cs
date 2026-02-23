namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Lissotis;

/// <summary>
/// Interface defining characteristics of Lissotis (genus).
/// </summary>
public interface ILissotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
