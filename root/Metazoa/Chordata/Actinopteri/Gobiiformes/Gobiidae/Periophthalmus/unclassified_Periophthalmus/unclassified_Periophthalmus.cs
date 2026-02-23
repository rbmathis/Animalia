using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Periophthalmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Periophthalmus.unclassified_Periophthalmus;

/// <summary>
/// Abstract class for unclassified Periophthalmus (no rank).
/// NCBI TaxId: 2623494
/// </summary>
public abstract class unclassified_Periophthalmus : Periophthalmus, Iunclassified_Periophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Periophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623494;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Periophthalmus";
}
