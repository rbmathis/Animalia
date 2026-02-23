namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae.Aulostomus;

/// <summary>
/// Interface defining characteristics of Aulostomus (genus).
/// </summary>
public interface IAulostomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
