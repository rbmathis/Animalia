using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Atractosteus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.Lepisosteidae.Atractosteus.unclassified_Atractosteus;

/// <summary>
/// Abstract class for unclassified Atractosteus (no rank).
/// NCBI TaxId: 2621840
/// </summary>
public abstract class unclassified_Atractosteus : Atractosteus, Iunclassified_Atractosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atractosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621840;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atractosteus";
}
