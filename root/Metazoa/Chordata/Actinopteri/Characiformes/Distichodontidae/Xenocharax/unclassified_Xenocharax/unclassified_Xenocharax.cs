using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Xenocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Xenocharax.unclassified_Xenocharax;

/// <summary>
/// Abstract class for unclassified Xenocharax (no rank).
/// NCBI TaxId: 2645221
/// </summary>
public abstract class unclassified_Xenocharax : Xenocharax, Iunclassified_Xenocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645221;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenocharax";
}
