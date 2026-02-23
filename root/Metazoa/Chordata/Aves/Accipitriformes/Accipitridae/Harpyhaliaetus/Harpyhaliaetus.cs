using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Harpyhaliaetus;

/// <summary>
/// Abstract class for Harpyhaliaetus (genus).
/// NCBI TaxId: 321133
/// </summary>
public abstract class Harpyhaliaetus : Accipitridae, IHarpyhaliaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpyhaliaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321133;

    /// <inheritdoc />
    public virtual string GenusName => "Harpyhaliaetus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
