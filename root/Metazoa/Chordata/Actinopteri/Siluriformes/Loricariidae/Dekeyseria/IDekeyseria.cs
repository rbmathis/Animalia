namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dekeyseria;

/// <summary>
/// Interface defining characteristics of Dekeyseria (genus).
/// </summary>
public interface IDekeyseria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
