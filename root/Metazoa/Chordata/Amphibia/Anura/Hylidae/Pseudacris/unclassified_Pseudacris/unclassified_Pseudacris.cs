using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pseudacris;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pseudacris.unclassified_Pseudacris;

/// <summary>
/// Abstract class for unclassified Pseudacris (no rank).
/// NCBI TaxId: 2896678
/// </summary>
public abstract class unclassified_Pseudacris : Pseudacris, Iunclassified_Pseudacris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudacris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2896678;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudacris";
}
