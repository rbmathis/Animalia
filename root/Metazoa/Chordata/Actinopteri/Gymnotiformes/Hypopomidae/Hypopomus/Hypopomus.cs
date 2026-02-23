using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Hypopomus;

/// <summary>
/// Abstract class for Hypopomus (genus).
/// NCBI TaxId: 36689
/// </summary>
public abstract class Hypopomus : Hypopomidae, IHypopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36689;

    /// <inheritdoc />
    public virtual string GenusName => "Hypopomus";

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
