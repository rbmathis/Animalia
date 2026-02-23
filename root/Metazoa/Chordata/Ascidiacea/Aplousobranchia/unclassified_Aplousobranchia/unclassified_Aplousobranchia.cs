using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.unclassified_Aplousobranchia;

/// <summary>
/// Abstract class for unclassified Aplousobranchia (no rank).
/// NCBI TaxId: 2501424
/// </summary>
public abstract class unclassified_Aplousobranchia : Aplousobranchia, Iunclassified_Aplousobranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aplousobranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2501424;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aplousobranchia";
}
