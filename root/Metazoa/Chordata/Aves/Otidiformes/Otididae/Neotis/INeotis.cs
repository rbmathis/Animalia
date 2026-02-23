namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Neotis;

/// <summary>
/// Interface defining characteristics of Neotis (genus).
/// </summary>
public interface INeotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
