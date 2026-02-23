namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Congomys;

/// <summary>
/// Interface defining characteristics of Congomys (genus).
/// </summary>
public interface ICongomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
