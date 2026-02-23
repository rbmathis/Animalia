using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Neotrygon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Neotrygon.unclassified_Neotrygon;

/// <summary>
/// Abstract class for unclassified Neotrygon (no rank).
/// NCBI TaxId: 2603162
/// </summary>
public abstract class unclassified_Neotrygon : Neotrygon, Iunclassified_Neotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2603162;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neotrygon";
}
