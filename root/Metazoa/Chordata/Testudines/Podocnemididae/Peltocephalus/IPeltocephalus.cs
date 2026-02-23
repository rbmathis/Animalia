namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Peltocephalus;

/// <summary>
/// Interface defining characteristics of Peltocephalus (genus).
/// </summary>
public interface IPeltocephalus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
