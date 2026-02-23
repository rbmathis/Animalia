using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Bivibranchia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Bivibranchia.unclassified_Bivibranchia;

/// <summary>
/// Abstract class for unclassified Bivibranchia (no rank).
/// NCBI TaxId: 3101817
/// </summary>
public abstract class unclassified_Bivibranchia : Bivibranchia, Iunclassified_Bivibranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bivibranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101817;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bivibranchia";
}
