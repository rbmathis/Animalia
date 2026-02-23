using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Nyctixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Nyctixalus.unclassified_Nyctixalus;

/// <summary>
/// Abstract class for unclassified Nyctixalus (no rank).
/// NCBI TaxId: 2620065
/// </summary>
public abstract class unclassified_Nyctixalus : Nyctixalus, Iunclassified_Nyctixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620065;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctixalus";
}
