namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Dumetia;

/// <summary>
/// Interface defining characteristics of Dumetia (genus).
/// </summary>
public interface IDumetia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
