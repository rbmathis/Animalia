namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

/// <summary>
/// Interface defining characteristics of Pithecia (genus).
/// </summary>
public interface IPithecia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
