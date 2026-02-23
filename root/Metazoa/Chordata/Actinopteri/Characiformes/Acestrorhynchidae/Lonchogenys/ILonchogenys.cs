namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhynchidae.Lonchogenys;

/// <summary>
/// Interface defining characteristics of Lonchogenys (genus).
/// </summary>
public interface ILonchogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
