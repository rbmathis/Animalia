namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Psammomys;

/// <summary>
/// Interface defining characteristics of Psammomys (genus).
/// </summary>
public interface IPsammomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
