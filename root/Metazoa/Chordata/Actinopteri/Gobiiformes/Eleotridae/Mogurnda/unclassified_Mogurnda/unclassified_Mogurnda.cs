using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Mogurnda;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Mogurnda.unclassified_Mogurnda;

/// <summary>
/// Abstract class for unclassified Mogurnda (no rank).
/// NCBI TaxId: 2649756
/// </summary>
public abstract class unclassified_Mogurnda : Mogurnda, Iunclassified_Mogurnda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mogurnda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649756;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mogurnda";
}
