namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Eliomys;

/// <summary>
/// Interface defining characteristics of Eliomys (genus).
/// </summary>
public interface IEliomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
