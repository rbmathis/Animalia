using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Paraplotosus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Paraplotosus.unclassified_Paraplotosus;

/// <summary>
/// Abstract class for unclassified Paraplotosus (no rank).
/// NCBI TaxId: 3051881
/// </summary>
public abstract class unclassified_Paraplotosus : Paraplotosus, Iunclassified_Paraplotosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paraplotosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paraplotosus";
}
