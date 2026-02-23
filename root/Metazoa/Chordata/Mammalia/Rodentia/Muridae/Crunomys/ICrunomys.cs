namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crunomys;

/// <summary>
/// Interface defining characteristics of Crunomys (genus).
/// </summary>
public interface ICrunomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
