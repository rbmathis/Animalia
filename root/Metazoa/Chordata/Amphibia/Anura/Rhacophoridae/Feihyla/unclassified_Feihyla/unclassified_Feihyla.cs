using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Feihyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Feihyla.unclassified_Feihyla;

/// <summary>
/// Abstract class for unclassified Feihyla (no rank).
/// NCBI TaxId: 2777173
/// </summary>
public abstract class unclassified_Feihyla : Feihyla, Iunclassified_Feihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Feihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2777173;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Feihyla";
}
