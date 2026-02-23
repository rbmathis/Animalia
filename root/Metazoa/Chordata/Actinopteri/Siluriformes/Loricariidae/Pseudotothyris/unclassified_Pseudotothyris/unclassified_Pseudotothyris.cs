using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudotothyris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudotothyris.unclassified_Pseudotothyris;

/// <summary>
/// Abstract class for unclassified Pseudotothyris (no rank).
/// NCBI TaxId: 2642442
/// </summary>
public abstract class unclassified_Pseudotothyris : Pseudotothyris, Iunclassified_Pseudotothyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudotothyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642442;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudotothyris";
}
