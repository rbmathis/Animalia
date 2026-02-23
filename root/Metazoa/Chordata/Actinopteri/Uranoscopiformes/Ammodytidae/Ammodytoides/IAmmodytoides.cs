namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytoides;

/// <summary>
/// Interface defining characteristics of Ammodytoides (genus).
/// </summary>
public interface IAmmodytoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
