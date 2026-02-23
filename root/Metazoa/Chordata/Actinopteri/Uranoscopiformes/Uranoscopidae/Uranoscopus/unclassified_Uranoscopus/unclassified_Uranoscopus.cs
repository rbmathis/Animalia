using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Uranoscopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Uranoscopus.unclassified_Uranoscopus;

/// <summary>
/// Abstract class for unclassified Uranoscopus (no rank).
/// NCBI TaxId: 2625254
/// </summary>
public abstract class unclassified_Uranoscopus : Uranoscopus, Iunclassified_Uranoscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uranoscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625254;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uranoscopus";
}
