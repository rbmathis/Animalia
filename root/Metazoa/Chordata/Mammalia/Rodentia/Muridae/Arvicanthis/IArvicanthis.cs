namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Arvicanthis;

/// <summary>
/// Interface defining characteristics of Arvicanthis (genus).
/// </summary>
public interface IArvicanthis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
