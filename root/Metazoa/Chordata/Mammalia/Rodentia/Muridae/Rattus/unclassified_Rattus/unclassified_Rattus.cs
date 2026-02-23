using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus.unclassified_Rattus;

/// <summary>
/// Abstract class for unclassified Rattus (no rank).
/// NCBI TaxId: 435433
/// </summary>
public abstract class unclassified_Rattus : Rattus, Iunclassified_Rattus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rattus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rattus";
}
