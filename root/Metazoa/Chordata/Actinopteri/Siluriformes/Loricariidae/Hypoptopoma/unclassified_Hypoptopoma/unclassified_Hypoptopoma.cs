using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypoptopoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypoptopoma.unclassified_Hypoptopoma;

/// <summary>
/// Abstract class for unclassified Hypoptopoma (no rank).
/// NCBI TaxId: 2620722
/// </summary>
public abstract class unclassified_Hypoptopoma : Hypoptopoma, Iunclassified_Hypoptopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypoptopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620722;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypoptopoma";
}
