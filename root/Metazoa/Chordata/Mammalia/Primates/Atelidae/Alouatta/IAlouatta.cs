namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Interface defining characteristics of Alouatta (genus).
/// </summary>
public interface IAlouatta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
