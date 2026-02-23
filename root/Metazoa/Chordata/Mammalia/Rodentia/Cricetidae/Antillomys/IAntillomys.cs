namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Antillomys;

/// <summary>
/// Interface defining characteristics of Antillomys (genus).
/// </summary>
public interface IAntillomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
