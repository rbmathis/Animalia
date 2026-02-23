using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eligmodontia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eligmodontia.unclassified_Eligmodontia;

/// <summary>
/// Abstract class for unclassified Eligmodontia (no rank).
/// NCBI TaxId: 2627589
/// </summary>
public abstract class unclassified_Eligmodontia : Eligmodontia, Iunclassified_Eligmodontia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eligmodontia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627589;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eligmodontia";
}
