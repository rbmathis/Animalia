namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dasyloricaria;

/// <summary>
/// Interface defining characteristics of Dasyloricaria (genus).
/// </summary>
public interface IDasyloricaria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
