namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae.Castoroides;

/// <summary>
/// Interface defining characteristics of Castoroides (genus).
/// </summary>
public interface ICastoroides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
