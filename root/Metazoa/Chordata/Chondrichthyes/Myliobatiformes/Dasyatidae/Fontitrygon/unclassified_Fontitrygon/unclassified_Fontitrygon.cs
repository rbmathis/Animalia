using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Fontitrygon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Fontitrygon.unclassified_Fontitrygon;

/// <summary>
/// Abstract class for unclassified Fontitrygon (no rank).
/// NCBI TaxId: 2978764
/// </summary>
public abstract class unclassified_Fontitrygon : Fontitrygon, Iunclassified_Fontitrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fontitrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2978764;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fontitrygon";
}
