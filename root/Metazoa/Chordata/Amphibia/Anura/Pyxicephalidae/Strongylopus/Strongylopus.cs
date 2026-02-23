using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Strongylopus;

/// <summary>
/// Abstract class for Strongylopus (genus).
/// NCBI TaxId: 143647
/// </summary>
public abstract class Strongylopus : Pyxicephalidae, IStrongylopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strongylopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143647;

    /// <inheritdoc />
    public virtual string GenusName => "Strongylopus";

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
