using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Phenacogaster;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Phenacogaster.unclassified_Phenacogaster;

/// <summary>
/// Abstract class for unclassified Phenacogaster (no rank).
/// NCBI TaxId: 2633840
/// </summary>
public abstract class unclassified_Phenacogaster : Phenacogaster, Iunclassified_Phenacogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phenacogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633840;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phenacogaster";
}
