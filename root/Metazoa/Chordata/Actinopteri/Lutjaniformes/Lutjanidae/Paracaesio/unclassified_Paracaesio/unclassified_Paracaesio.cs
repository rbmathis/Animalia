using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Paracaesio;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Paracaesio.unclassified_Paracaesio;

/// <summary>
/// Abstract class for unclassified Paracaesio (no rank).
/// NCBI TaxId: 2649225
/// </summary>
public abstract class unclassified_Paracaesio : Paracaesio, Iunclassified_Paracaesio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracaesio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649225;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracaesio";
}
