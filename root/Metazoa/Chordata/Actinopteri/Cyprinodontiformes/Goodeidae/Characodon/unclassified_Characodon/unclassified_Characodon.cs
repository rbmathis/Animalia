using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Characodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Characodon.unclassified_Characodon;

/// <summary>
/// Abstract class for unclassified Characodon (no rank).
/// NCBI TaxId: 3404031
/// </summary>
public abstract class unclassified_Characodon : Characodon, Iunclassified_Characodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Characodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3404031;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Characodon";
}
