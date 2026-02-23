using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Ichthyscopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Ichthyscopus.unclassified_Ichthyscopus;

/// <summary>
/// Abstract class for unclassified Ichthyscopus (no rank).
/// NCBI TaxId: 3445700
/// </summary>
public abstract class unclassified_Ichthyscopus : Ichthyscopus, Iunclassified_Ichthyscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ichthyscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3445700;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ichthyscopus";
}
