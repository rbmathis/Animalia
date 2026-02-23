using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lampridae.Lampris;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lampridae.Lampris.unclassified_Lampris;

/// <summary>
/// Abstract class for unclassified Lampris (no rank).
/// NCBI TaxId: 2617697
/// </summary>
public abstract class unclassified_Lampris : Lampris, Iunclassified_Lampris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lampris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617697;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lampris";
}
