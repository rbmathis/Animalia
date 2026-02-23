namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Climacteridae.Climacteris;

/// <summary>
/// Interface defining characteristics of Climacteris (genus).
/// </summary>
public interface IClimacteris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
