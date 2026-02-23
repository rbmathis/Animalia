using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Dysomma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Dysomma.unclassified_Dysomma;

/// <summary>
/// Abstract class for unclassified Dysomma (no rank).
/// NCBI TaxId: 2644865
/// </summary>
public abstract class unclassified_Dysomma : Dysomma, Iunclassified_Dysomma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dysomma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644865;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dysomma";
}
