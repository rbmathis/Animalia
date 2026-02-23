using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Malacosteus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Malacosteus.unclassified_Malacosteus;

/// <summary>
/// Abstract class for unclassified Malacosteus (no rank).
/// NCBI TaxId: 2618520
/// </summary>
public abstract class unclassified_Malacosteus : Malacosteus, Iunclassified_Malacosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Malacosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618520;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Malacosteus";
}
