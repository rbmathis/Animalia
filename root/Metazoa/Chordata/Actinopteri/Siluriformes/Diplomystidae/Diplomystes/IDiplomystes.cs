namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae.Diplomystes;

/// <summary>
/// Interface defining characteristics of Diplomystes (genus).
/// </summary>
public interface IDiplomystes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
