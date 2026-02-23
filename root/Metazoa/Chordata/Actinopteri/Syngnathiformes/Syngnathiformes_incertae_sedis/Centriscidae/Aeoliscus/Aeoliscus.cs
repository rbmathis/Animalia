using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae.Aeoliscus;

/// <summary>
/// Abstract class for Aeoliscus (genus).
/// NCBI TaxId: 270545
/// </summary>
public abstract class Aeoliscus : Centriscidae, IAeoliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aeoliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270545;

    /// <inheritdoc />
    public virtual string GenusName => "Aeoliscus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
