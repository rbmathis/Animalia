using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Lepisosteus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Lepisosteus.unclassified_Lepisosteus;

/// <summary>
/// Abstract class for unclassified Lepisosteus (no rank).
/// NCBI TaxId: 2623238
/// </summary>
public abstract class unclassified_Lepisosteus : Lepisosteus, Iunclassified_Lepisosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepisosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623238;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepisosteus";
}
