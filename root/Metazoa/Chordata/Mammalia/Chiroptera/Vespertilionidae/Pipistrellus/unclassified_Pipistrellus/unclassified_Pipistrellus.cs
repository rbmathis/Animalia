using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus.unclassified_Pipistrellus;

/// <summary>
/// Abstract class for unclassified Pipistrellus (no rank).
/// NCBI TaxId: 1032380
/// </summary>
public abstract class unclassified_Pipistrellus : Pipistrellus, Iunclassified_Pipistrellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pipistrellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1032380;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pipistrellus";
}
