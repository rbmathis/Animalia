using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Nannaethiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Nannaethiops.unclassified_Nannaethiops;

/// <summary>
/// Abstract class for unclassified Nannaethiops (no rank).
/// NCBI TaxId: 3043736
/// </summary>
public abstract class unclassified_Nannaethiops : Nannaethiops, Iunclassified_Nannaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043736;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannaethiops";
}
