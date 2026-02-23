using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Lepidoblepharon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Citharidae.Lepidoblepharon.unclassified_Lepidoblepharon;

/// <summary>
/// Abstract class for unclassified Lepidoblepharon (no rank).
/// NCBI TaxId: 2646622
/// </summary>
public abstract class unclassified_Lepidoblepharon : Lepidoblepharon, Iunclassified_Lepidoblepharon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidoblepharon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646622;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidoblepharon";
}
