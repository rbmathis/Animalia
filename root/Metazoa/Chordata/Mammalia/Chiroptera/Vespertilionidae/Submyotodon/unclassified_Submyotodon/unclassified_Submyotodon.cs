using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Submyotodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Submyotodon.unclassified_Submyotodon;

/// <summary>
/// Abstract class for unclassified Submyotodon (no rank).
/// NCBI TaxId: 2951462
/// </summary>
public abstract class unclassified_Submyotodon : Submyotodon, Iunclassified_Submyotodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Submyotodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2951462;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Submyotodon";
}
