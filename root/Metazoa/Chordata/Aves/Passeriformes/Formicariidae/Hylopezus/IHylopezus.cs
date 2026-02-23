namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Hylopezus;

/// <summary>
/// Interface defining characteristics of Hylopezus (genus).
/// </summary>
public interface IHylopezus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
