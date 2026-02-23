using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Stromateus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Stromateus.unclassified_Stromateus;

/// <summary>
/// Abstract class for unclassified Stromateus (no rank).
/// NCBI TaxId: 2647655
/// </summary>
public abstract class unclassified_Stromateus : Stromateus, Iunclassified_Stromateus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stromateus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647655;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stromateus";
}
