using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.unclassified_Lebiasinidae.Nannobrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.unclassified_Lebiasinidae.Nannobrycon.unclassified_Nannobrycon;

/// <summary>
/// Abstract class for unclassified Nannobrycon (no rank).
/// NCBI TaxId: 2617783
/// </summary>
public abstract class unclassified_Nannobrycon : Nannobrycon, Iunclassified_Nannobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617783;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannobrycon";
}
