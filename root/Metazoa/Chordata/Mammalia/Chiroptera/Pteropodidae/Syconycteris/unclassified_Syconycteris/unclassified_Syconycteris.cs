using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Syconycteris;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Syconycteris.unclassified_Syconycteris;

/// <summary>
/// Abstract class for unclassified Syconycteris (no rank).
/// NCBI TaxId: 2634128
/// </summary>
public abstract class unclassified_Syconycteris : Syconycteris, Iunclassified_Syconycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syconycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syconycteris";
}
