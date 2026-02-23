using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Electrophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Electrophorus.unclassified_Electrophorus;

/// <summary>
/// Abstract class for unclassified Electrophorus (no rank).
/// NCBI TaxId: 2684925
/// </summary>
public abstract class unclassified_Electrophorus : Electrophorus, Iunclassified_Electrophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Electrophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Electrophorus";
}
