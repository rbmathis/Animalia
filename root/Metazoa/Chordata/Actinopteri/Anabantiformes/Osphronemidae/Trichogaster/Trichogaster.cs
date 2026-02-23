using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichogaster;

/// <summary>
/// Abstract class for Trichogaster (genus).
/// NCBI TaxId: 96902
/// </summary>
public abstract class Trichogaster : Osphronemidae, ITrichogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96902;

    /// <inheritdoc />
    public virtual string GenusName => "Trichogaster";

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
