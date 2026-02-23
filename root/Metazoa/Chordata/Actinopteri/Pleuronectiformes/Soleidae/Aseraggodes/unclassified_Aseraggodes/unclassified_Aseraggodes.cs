using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Aseraggodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Aseraggodes.unclassified_Aseraggodes;

/// <summary>
/// Abstract class for unclassified Aseraggodes (no rank).
/// NCBI TaxId: 2619601
/// </summary>
public abstract class unclassified_Aseraggodes : Aseraggodes, Iunclassified_Aseraggodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aseraggodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619601;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aseraggodes";
}
