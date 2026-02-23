using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Synaphobranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Synaphobranchus.unclassified_Synaphobranchus;

/// <summary>
/// Abstract class for unclassified Synaphobranchus (no rank).
/// NCBI TaxId: 2636465
/// </summary>
public abstract class unclassified_Synaphobranchus : Synaphobranchus, Iunclassified_Synaphobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synaphobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636465;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synaphobranchus";
}
