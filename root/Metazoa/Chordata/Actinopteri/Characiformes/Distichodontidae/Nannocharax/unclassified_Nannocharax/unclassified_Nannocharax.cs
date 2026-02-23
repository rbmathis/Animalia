using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Nannocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Nannocharax.unclassified_Nannocharax;

/// <summary>
/// Abstract class for unclassified Nannocharax (no rank).
/// NCBI TaxId: 2645013
/// </summary>
public abstract class unclassified_Nannocharax : Nannocharax, Iunclassified_Nannocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645013;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannocharax";
}
