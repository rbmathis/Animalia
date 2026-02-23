namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytes;

/// <summary>
/// Interface defining characteristics of Ammodytes (genus).
/// </summary>
public interface IAmmodytes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
