using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiodon.unclassified_Gobiodon;

/// <summary>
/// Abstract class for unclassified Gobiodon (no rank).
/// NCBI TaxId: 2643940
/// </summary>
public abstract class unclassified_Gobiodon : Gobiodon, Iunclassified_Gobiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643940;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiodon";
}
