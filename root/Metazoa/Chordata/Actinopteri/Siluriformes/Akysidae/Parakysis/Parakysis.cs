using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Parakysis;

/// <summary>
/// Abstract class for Parakysis (genus).
/// NCBI TaxId: 385304
/// </summary>
public abstract class Parakysis : Akysidae, IParakysis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parakysis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385304;

    /// <inheritdoc />
    public virtual string GenusName => "Parakysis";

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
