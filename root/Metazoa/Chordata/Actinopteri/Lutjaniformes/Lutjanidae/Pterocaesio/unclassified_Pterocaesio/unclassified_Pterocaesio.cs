using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Pterocaesio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Pterocaesio.unclassified_Pterocaesio;

/// <summary>
/// Abstract class for unclassified Pterocaesio (no rank).
/// NCBI TaxId: 2641639
/// </summary>
public abstract class unclassified_Pterocaesio : Pterocaesio, Iunclassified_Pterocaesio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterocaesio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641639;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterocaesio";
}
