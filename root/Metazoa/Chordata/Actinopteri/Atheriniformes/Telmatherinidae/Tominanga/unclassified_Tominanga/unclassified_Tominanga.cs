using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Tominanga;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Tominanga.unclassified_Tominanga;

/// <summary>
/// Abstract class for unclassified Tominanga (no rank).
/// NCBI TaxId: 2617530
/// </summary>
public abstract class unclassified_Tominanga : Tominanga, Iunclassified_Tominanga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tominanga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tominanga";
}
