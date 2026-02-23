namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Dreptes;

/// <summary>
/// Interface defining characteristics of Dreptes (genus).
/// </summary>
public interface IDreptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
