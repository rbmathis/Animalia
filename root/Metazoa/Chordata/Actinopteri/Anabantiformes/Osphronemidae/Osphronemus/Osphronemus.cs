using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Osphronemus;

/// <summary>
/// Abstract class for Osphronemus (genus).
/// NCBI TaxId: 270603
/// </summary>
public abstract class Osphronemus : Osphronemidae, IOsphronemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osphronemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270603;

    /// <inheritdoc />
    public virtual string GenusName => "Osphronemus";

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
