namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

/// <summary>
/// Interface defining characteristics of Reithrodontomys (genus).
/// </summary>
public interface IReithrodontomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
