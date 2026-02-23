using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Trididemnum;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Trididemnum.unclassified_Trididemnum;

/// <summary>
/// Abstract class for unclassified Trididemnum (no rank).
/// NCBI TaxId: 2628962
/// </summary>
public abstract class unclassified_Trididemnum : Trididemnum, Iunclassified_Trididemnum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trididemnum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628962;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trididemnum";
}
