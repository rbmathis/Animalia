using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Allopaa;

/// <summary>
/// Abstract class for Allopaa (genus).
/// NCBI TaxId: 2811909
/// </summary>
public abstract class Allopaa : Dicroglossidae, IAllopaa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allopaa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2811909;

    /// <inheritdoc />
    public virtual string GenusName => "Allopaa";

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
