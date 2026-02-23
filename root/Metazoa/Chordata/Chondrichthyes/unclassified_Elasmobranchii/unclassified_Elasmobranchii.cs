using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Elasmobranchii;

/// <summary>
/// Abstract class for unclassified Elasmobranchii (no rank).
/// NCBI TaxId: 641951
/// </summary>
public abstract class unclassified_Elasmobranchii : Chondrichthyes, Iunclassified_Elasmobranchii
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elasmobranchii";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641951;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elasmobranchii";
}
