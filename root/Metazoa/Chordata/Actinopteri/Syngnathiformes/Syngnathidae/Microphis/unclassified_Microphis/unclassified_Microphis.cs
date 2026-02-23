using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Microphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Microphis.unclassified_Microphis;

/// <summary>
/// Abstract class for unclassified Microphis (no rank).
/// NCBI TaxId: 2640757
/// </summary>
public abstract class unclassified_Microphis : Microphis, Iunclassified_Microphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640757;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microphis";
}
