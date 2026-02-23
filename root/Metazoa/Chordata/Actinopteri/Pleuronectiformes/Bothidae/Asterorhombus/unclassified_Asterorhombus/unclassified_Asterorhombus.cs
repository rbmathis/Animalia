using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Asterorhombus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Asterorhombus.unclassified_Asterorhombus;

/// <summary>
/// Abstract class for unclassified Asterorhombus (no rank).
/// NCBI TaxId: 3451253
/// </summary>
public abstract class unclassified_Asterorhombus : Asterorhombus, Iunclassified_Asterorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Asterorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3451253;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Asterorhombus";
}
