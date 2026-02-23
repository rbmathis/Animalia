namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Nannoptopoma;

/// <summary>
/// Interface defining characteristics of Nannoptopoma (genus).
/// </summary>
public interface INannoptopoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
