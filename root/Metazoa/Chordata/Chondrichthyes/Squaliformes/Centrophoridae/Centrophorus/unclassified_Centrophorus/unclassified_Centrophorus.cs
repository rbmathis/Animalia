using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Centrophorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Centrophorus.unclassified_Centrophorus;

/// <summary>
/// Abstract class for unclassified Centrophorus (no rank).
/// NCBI TaxId: 2623078
/// </summary>
public abstract class unclassified_Centrophorus : Centrophorus, Iunclassified_Centrophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centrophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623078;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centrophorus";
}
