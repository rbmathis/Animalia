namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Triakidae.Triakis;

/// <summary>
/// Interface defining characteristics of Triakis (genus).
/// </summary>
public interface ITriakis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
