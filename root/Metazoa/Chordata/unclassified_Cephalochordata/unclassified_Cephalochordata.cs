using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Cephalochordata;

/// <summary>
/// Abstract class for unclassified Cephalochordata (no rank).
/// NCBI TaxId: 1068512
/// </summary>
public abstract class unclassified_Cephalochordata : Chordata, Iunclassified_Cephalochordata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cephalochordata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1068512;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cephalochordata";
}
