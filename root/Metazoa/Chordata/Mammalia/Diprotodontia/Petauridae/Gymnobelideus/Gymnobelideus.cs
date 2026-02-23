using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Petauridae.Gymnobelideus;

/// <summary>
/// Abstract class for Gymnobelideus (genus).
/// NCBI TaxId: 38617
/// </summary>
public abstract class Gymnobelideus : Petauridae, IGymnobelideus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnobelideus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38617;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnobelideus";

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
