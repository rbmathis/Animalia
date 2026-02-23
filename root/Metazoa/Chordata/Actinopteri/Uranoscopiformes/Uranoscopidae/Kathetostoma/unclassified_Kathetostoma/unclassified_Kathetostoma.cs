using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Kathetostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Kathetostoma.unclassified_Kathetostoma;

/// <summary>
/// Abstract class for unclassified Kathetostoma (no rank).
/// NCBI TaxId: 2635286
/// </summary>
public abstract class unclassified_Kathetostoma : Kathetostoma, Iunclassified_Kathetostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kathetostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635286;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kathetostoma";
}
