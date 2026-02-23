using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hazeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Hazeus.unclassified_Hazeus;

/// <summary>
/// Abstract class for unclassified Hazeus (no rank).
/// NCBI TaxId: 2896474
/// </summary>
public abstract class unclassified_Hazeus : Hazeus, Iunclassified_Hazeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hazeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2896474;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hazeus";
}
