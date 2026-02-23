using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Harpagiferidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Harpagiferidae.Harpagifer;

/// <summary>
/// Abstract class for Harpagifer (genus).
/// NCBI TaxId: 43255
/// </summary>
public abstract class Harpagifer : Harpagiferidae, IHarpagifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpagifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43255;

    /// <inheritdoc />
    public virtual string GenusName => "Harpagifer";

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
