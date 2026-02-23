using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Brevitrygon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Brevitrygon.unclassified_Brevitrygon;

/// <summary>
/// Abstract class for unclassified Brevitrygon (no rank).
/// NCBI TaxId: 2599779
/// </summary>
public abstract class unclassified_Brevitrygon : Brevitrygon, Iunclassified_Brevitrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brevitrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brevitrygon";
}
