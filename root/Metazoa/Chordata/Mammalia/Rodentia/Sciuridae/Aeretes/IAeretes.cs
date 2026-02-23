namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Aeretes;

/// <summary>
/// Interface defining characteristics of Aeretes (genus).
/// </summary>
public interface IAeretes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
