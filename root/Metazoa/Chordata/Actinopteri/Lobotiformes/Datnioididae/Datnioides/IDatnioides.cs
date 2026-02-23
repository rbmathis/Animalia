namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Datnioididae.Datnioides;

/// <summary>
/// Interface defining characteristics of Datnioides (genus).
/// </summary>
public interface IDatnioides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
