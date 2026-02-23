namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uranomys;

/// <summary>
/// Interface defining characteristics of Uranomys (genus).
/// </summary>
public interface IUranomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
