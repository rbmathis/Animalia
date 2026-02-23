using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Centropyge;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Pomacanthidae.Centropyge.unclassified_Centropyge;

/// <summary>
/// Abstract class for unclassified Centropyge (no rank).
/// NCBI TaxId: 2645955
/// </summary>
public abstract class unclassified_Centropyge : Centropyge, Iunclassified_Centropyge
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centropyge";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centropyge";
}
