namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tateomys;

/// <summary>
/// Interface defining characteristics of Tateomys (genus).
/// </summary>
public interface ITateomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
