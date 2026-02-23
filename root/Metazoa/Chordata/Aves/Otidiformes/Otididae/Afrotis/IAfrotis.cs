namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Afrotis;

/// <summary>
/// Interface defining characteristics of Afrotis (genus).
/// </summary>
public interface IAfrotis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
