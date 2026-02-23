using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae.Centriscops;

/// <summary>
/// Abstract class for Centriscops (genus).
/// NCBI TaxId: 2696654
/// </summary>
public abstract class Centriscops : Centriscidae, ICentriscops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centriscops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696654;

    /// <inheritdoc />
    public virtual string GenusName => "Centriscops";

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
