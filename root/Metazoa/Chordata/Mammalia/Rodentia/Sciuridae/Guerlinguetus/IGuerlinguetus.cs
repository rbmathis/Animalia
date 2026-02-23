namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Guerlinguetus;

/// <summary>
/// Interface defining characteristics of Guerlinguetus (genus).
/// </summary>
public interface IGuerlinguetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
