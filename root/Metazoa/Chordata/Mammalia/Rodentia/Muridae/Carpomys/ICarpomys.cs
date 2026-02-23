namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Carpomys;

/// <summary>
/// Interface defining characteristics of Carpomys (genus).
/// </summary>
public interface ICarpomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
