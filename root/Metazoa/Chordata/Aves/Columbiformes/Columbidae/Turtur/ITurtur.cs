namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Turtur;

/// <summary>
/// Interface defining characteristics of Turtur (genus).
/// </summary>
public interface ITurtur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
