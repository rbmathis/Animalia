using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Micronycteris;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Micronycteris.unclassified_Micronycteris;

/// <summary>
/// Abstract class for unclassified Micronycteris (no rank).
/// NCBI TaxId: 2624502
/// </summary>
public abstract class unclassified_Micronycteris : Micronycteris, Iunclassified_Micronycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micronycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624502;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micronycteris";
}
