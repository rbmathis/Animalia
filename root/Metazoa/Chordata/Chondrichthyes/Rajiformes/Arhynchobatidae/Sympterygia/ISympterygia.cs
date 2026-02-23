namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Sympterygia;

/// <summary>
/// Interface defining characteristics of Sympterygia (genus).
/// </summary>
public interface ISympterygia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
