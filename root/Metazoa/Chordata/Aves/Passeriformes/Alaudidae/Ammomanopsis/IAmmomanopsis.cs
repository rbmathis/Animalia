namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Ammomanopsis;

/// <summary>
/// Interface defining characteristics of Ammomanopsis (genus).
/// </summary>
public interface IAmmomanopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
