namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dacnomys;

/// <summary>
/// Interface defining characteristics of Dacnomys (genus).
/// </summary>
public interface IDacnomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
