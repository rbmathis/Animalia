namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Selenidera;

/// <summary>
/// Interface defining characteristics of Selenidera (genus).
/// </summary>
public interface ISelenidera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
