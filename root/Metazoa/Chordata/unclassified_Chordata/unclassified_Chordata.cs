using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Chordata;

/// <summary>
/// Abstract class for unclassified Chordata (no rank).
/// NCBI TaxId: 1003298
/// </summary>
public abstract class unclassified_Chordata : Chordata, Iunclassified_Chordata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chordata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003298;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chordata";
}
