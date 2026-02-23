using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Myonycteris;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Myonycteris.unclassified_Myonycteris;

/// <summary>
/// Abstract class for unclassified Myonycteris (no rank).
/// NCBI TaxId: 2624632
/// </summary>
public abstract class unclassified_Myonycteris : Myonycteris, Iunclassified_Myonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624632;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myonycteris";
}
