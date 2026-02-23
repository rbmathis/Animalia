namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Petromuridae.Petromus;

/// <summary>
/// Interface defining characteristics of Petromus (genus).
/// </summary>
public interface IPetromus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
