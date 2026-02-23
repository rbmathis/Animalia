namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariidae_incertae_sedis.Nannoplecostomus;

/// <summary>
/// Interface defining characteristics of Nannoplecostomus (genus).
/// </summary>
public interface INannoplecostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
