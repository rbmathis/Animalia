namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ornorectes;

/// <summary>
/// Interface defining characteristics of Ornorectes (genus).
/// </summary>
public interface IOrnorectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
