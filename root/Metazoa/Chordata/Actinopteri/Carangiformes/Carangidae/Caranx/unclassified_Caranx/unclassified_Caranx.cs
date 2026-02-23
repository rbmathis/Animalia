using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Caranx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Caranx.unclassified_Caranx;

/// <summary>
/// Abstract class for unclassified Caranx (no rank).
/// NCBI TaxId: 2645842
/// </summary>
public abstract class unclassified_Caranx : Caranx, Iunclassified_Caranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645842;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caranx";
}
