namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paucidentomys;

/// <summary>
/// Interface defining characteristics of Paucidentomys (genus).
/// </summary>
public interface IPaucidentomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
