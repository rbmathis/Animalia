namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

/// <summary>
/// Interface defining characteristics of Otomys (genus).
/// </summary>
public interface IOtomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
