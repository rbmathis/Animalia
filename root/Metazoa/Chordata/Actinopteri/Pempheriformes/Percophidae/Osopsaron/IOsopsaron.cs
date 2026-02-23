namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Osopsaron;

/// <summary>
/// Interface defining characteristics of Osopsaron (genus).
/// </summary>
public interface IOsopsaron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
