using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Varicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Varicus.unclassified_Varicus;

/// <summary>
/// Abstract class for unclassified Varicus (no rank).
/// NCBI TaxId: 2621004
/// </summary>
public abstract class unclassified_Varicus : Varicus, Iunclassified_Varicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Varicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621004;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Varicus";
}
