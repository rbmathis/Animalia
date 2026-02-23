namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Micrastur;

/// <summary>
/// Interface defining characteristics of Micrastur (genus).
/// </summary>
public interface IMicrastur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
