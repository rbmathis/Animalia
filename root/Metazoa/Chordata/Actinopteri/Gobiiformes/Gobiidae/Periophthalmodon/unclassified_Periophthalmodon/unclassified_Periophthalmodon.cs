using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Periophthalmodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Periophthalmodon.unclassified_Periophthalmodon;

/// <summary>
/// Abstract class for unclassified Periophthalmodon (no rank).
/// NCBI TaxId: 3385987
/// </summary>
public abstract class unclassified_Periophthalmodon : Periophthalmodon, Iunclassified_Periophthalmodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Periophthalmodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3385987;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Periophthalmodon";
}
