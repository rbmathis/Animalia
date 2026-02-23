using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Aplidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Aplidium.unclassified_Aplidium;

/// <summary>
/// Abstract class for unclassified Aplidium (no rank).
/// NCBI TaxId: 2621823
/// </summary>
public abstract class unclassified_Aplidium : Aplidium, Iunclassified_Aplidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aplidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621823;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aplidium";
}
