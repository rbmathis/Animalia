using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana.unclassified_Rana_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Rana (in: frogs & toads) (no rank).
/// NCBI TaxId: 3407090
/// </summary>
public abstract class unclassified_Rana_in_frogs__toads : Rana, Iunclassified_Rana_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rana (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3407090;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rana_in_frogs__toads";
}
