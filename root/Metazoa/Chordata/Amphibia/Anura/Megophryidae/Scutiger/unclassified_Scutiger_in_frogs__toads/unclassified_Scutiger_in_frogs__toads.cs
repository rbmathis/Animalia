using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Scutiger;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Scutiger.unclassified_Scutiger_in_frogs__toads;

/// <summary>
/// Abstract class for unclassified Scutiger (in: frogs & toads) (no rank).
/// NCBI TaxId: 2638287
/// </summary>
public abstract class unclassified_Scutiger_in_frogs__toads : Scutiger, Iunclassified_Scutiger_in_frogs__toads
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scutiger (in: frogs & toads)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638287;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scutiger_in_frogs__toads";
}
