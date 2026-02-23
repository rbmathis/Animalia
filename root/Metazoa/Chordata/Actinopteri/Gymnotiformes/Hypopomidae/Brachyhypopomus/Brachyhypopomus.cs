using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Brachyhypopomus;

/// <summary>
/// Abstract class for Brachyhypopomus (genus).
/// NCBI TaxId: 38295
/// </summary>
public abstract class Brachyhypopomus : Hypopomidae, IBrachyhypopomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyhypopomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38295;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyhypopomus";

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
