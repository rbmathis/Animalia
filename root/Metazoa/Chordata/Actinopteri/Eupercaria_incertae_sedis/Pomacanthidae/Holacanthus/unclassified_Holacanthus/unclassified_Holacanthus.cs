using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Holacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Holacanthus.unclassified_Holacanthus;

/// <summary>
/// Abstract class for unclassified Holacanthus (no rank).
/// NCBI TaxId: 2619389
/// </summary>
public abstract class unclassified_Holacanthus : Holacanthus, Iunclassified_Holacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Holacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619389;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Holacanthus";
}
