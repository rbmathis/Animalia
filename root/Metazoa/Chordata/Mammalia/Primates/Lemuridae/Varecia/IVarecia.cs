namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Varecia;

/// <summary>
/// Interface defining characteristics of Varecia (genus).
/// </summary>
public interface IVarecia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
