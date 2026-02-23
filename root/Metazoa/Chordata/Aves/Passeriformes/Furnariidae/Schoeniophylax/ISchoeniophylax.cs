namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Schoeniophylax;

/// <summary>
/// Interface defining characteristics of Schoeniophylax (genus).
/// </summary>
public interface ISchoeniophylax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
