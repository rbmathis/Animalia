namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Habia;

/// <summary>
/// Interface defining characteristics of Habia (genus).
/// </summary>
public interface IHabia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
