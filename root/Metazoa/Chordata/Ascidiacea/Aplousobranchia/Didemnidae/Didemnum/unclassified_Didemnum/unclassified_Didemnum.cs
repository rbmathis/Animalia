using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Didemnum;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Didemnum.unclassified_Didemnum;

/// <summary>
/// Abstract class for unclassified Didemnum (no rank).
/// NCBI TaxId: 2685049
/// </summary>
public abstract class unclassified_Didemnum : Didemnum, Iunclassified_Didemnum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Didemnum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685049;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Didemnum";
}
