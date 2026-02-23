using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Plotosus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Plotosus.unclassified_Plotosus;

/// <summary>
/// Abstract class for unclassified Plotosus (no rank).
/// NCBI TaxId: 2649275
/// </summary>
public abstract class unclassified_Plotosus : Plotosus, Iunclassified_Plotosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plotosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649275;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plotosus";
}
