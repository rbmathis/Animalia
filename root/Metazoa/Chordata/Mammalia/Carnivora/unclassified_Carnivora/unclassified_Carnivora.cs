using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.unclassified_Carnivora;

/// <summary>
/// Abstract class for unclassified Carnivora (no rank).
/// NCBI TaxId: 727684
/// </summary>
public abstract class unclassified_Carnivora : Carnivora, Iunclassified_Carnivora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carnivora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727684;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carnivora";
}
