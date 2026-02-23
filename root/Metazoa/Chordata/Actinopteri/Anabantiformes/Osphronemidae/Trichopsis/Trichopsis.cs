using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Trichopsis;

/// <summary>
/// Abstract class for Trichopsis (genus).
/// NCBI TaxId: 158453
/// </summary>
public abstract class Trichopsis : Osphronemidae, ITrichopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158453;

    /// <inheritdoc />
    public virtual string GenusName => "Trichopsis";

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
