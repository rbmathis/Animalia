namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Pteropsaron;

/// <summary>
/// Interface defining characteristics of Pteropsaron (genus).
/// </summary>
public interface IPteropsaron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
