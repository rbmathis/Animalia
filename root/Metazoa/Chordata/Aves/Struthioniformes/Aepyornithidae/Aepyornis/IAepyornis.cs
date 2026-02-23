namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Aepyornis;

/// <summary>
/// Interface defining characteristics of Aepyornis (genus).
/// </summary>
public interface IAepyornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
