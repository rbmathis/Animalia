namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Ramphocoris;

/// <summary>
/// Interface defining characteristics of Ramphocoris (genus).
/// </summary>
public interface IRamphocoris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
