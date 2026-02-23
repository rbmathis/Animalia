using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichopodus;

/// <summary>
/// Abstract class for Trichopodus (genus).
/// NCBI TaxId: 1679031
/// </summary>
public abstract class Trichopodus : Osphronemidae, ITrichopodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichopodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1679031;

    /// <inheritdoc />
    public virtual string GenusName => "Trichopodus";

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
