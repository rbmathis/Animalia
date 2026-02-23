using AnimalKingdom.root;

namespace AnimalKingdom.root.Metazoa;

/// <summary>
/// Abstract class for Metazoa (kingdom).
/// NCBI TaxId: 33208
/// </summary>
public abstract class Metazoa : root, IMetazoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metazoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "kingdom";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33208;

    /// <inheritdoc />
    public virtual string KingdomName => "Metazoa";

    /// <inheritdoc />
    public virtual string[] KingdomCharacteristics => new[]
    {
        "Multicellular",
        "Heterotrophic",
        "Lack cell walls",
        "Mobile at some life stage",
        "Sexual reproduction predominant"
    };

    /// <inheritdoc />
    public virtual bool IsMulticellular => true;

    /// <inheritdoc />
    public virtual string NutritionMode => "Heterotrophic";

    /// <inheritdoc />
    public virtual bool HasDifferentiatedTissues => true;

    /// <inheritdoc />
    public virtual string BodySymmetry => "Bilateral";

    /// <inheritdoc />
    public virtual bool HasEmbryonicDevelopment => true;

    /// <inheritdoc />
    public virtual int GermLayerCount => 3;

}
