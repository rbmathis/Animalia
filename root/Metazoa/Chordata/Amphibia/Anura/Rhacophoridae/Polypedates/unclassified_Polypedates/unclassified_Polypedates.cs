using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Polypedates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Polypedates.unclassified_Polypedates;

/// <summary>
/// Abstract class for unclassified Polypedates (no rank).
/// NCBI TaxId: 2620826
/// </summary>
public abstract class unclassified_Polypedates : Polypedates, Iunclassified_Polypedates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polypedates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620826;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polypedates";
}
