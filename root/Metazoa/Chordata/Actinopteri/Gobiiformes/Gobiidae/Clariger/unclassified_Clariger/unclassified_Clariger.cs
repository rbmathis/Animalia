using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Clariger;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Clariger.unclassified_Clariger;

/// <summary>
/// Abstract class for unclassified Clariger (no rank).
/// NCBI TaxId: 2636538
/// </summary>
public abstract class unclassified_Clariger : Clariger, Iunclassified_Clariger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clariger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636538;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clariger";
}
