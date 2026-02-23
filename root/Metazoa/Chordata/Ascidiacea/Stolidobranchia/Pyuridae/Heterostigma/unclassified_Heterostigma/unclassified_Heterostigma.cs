using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Heterostigma;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Heterostigma.unclassified_Heterostigma;

/// <summary>
/// Abstract class for unclassified Heterostigma (no rank).
/// NCBI TaxId: 3386093
/// </summary>
public abstract class unclassified_Heterostigma : Heterostigma, Iunclassified_Heterostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heterostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3386093;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heterostigma";
}
