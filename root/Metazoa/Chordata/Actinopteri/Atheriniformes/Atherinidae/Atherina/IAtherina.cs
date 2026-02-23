namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherina;

/// <summary>
/// Interface defining characteristics of Atherina (genus).
/// </summary>
public interface IAtherina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
