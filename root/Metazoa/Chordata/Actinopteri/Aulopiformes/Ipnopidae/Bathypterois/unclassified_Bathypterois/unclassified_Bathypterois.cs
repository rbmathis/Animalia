using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathypterois;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathypterois.unclassified_Bathypterois;

/// <summary>
/// Abstract class for unclassified Bathypterois (no rank).
/// NCBI TaxId: 2646242
/// </summary>
public abstract class unclassified_Bathypterois : Bathypterois, Iunclassified_Bathypterois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathypterois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646242;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathypterois";
}
