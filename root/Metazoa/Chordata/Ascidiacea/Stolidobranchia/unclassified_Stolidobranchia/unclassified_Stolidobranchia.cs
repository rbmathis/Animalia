using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.unclassified_Stolidobranchia;

/// <summary>
/// Abstract class for unclassified Stolidobranchia (no rank).
/// NCBI TaxId: 948982
/// </summary>
public abstract class unclassified_Stolidobranchia : Stolidobranchia, Iunclassified_Stolidobranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stolidobranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948982;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stolidobranchia";
}
