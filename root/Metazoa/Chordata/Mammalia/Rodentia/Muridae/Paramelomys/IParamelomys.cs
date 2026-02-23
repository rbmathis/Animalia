namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paramelomys;

/// <summary>
/// Interface defining characteristics of Paramelomys (genus).
/// </summary>
public interface IParamelomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
