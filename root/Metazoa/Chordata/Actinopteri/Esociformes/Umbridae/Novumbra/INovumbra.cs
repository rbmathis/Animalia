namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae.Novumbra;

/// <summary>
/// Interface defining characteristics of Novumbra (genus).
/// </summary>
public interface INovumbra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
