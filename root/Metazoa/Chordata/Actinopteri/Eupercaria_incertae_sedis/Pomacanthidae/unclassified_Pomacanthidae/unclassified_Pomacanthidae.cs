using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.unclassified_Pomacanthidae;

/// <summary>
/// Abstract class for unclassified Pomacanthidae (no rank).
/// NCBI TaxId: 1182287
/// </summary>
public abstract class unclassified_Pomacanthidae : Pomacanthidae, Iunclassified_Pomacanthidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pomacanthidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182287;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pomacanthidae";
}
