using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Urochordata;

/// <summary>
/// Abstract class for unclassified Urochordata (no rank).
/// NCBI TaxId: 220542
/// </summary>
public abstract class unclassified_Urochordata : Chordata, Iunclassified_Urochordata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Urochordata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220542;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Urochordata";
}
