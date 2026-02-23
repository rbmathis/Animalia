using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Chrysopaa;

/// <summary>
/// Abstract class for Chrysopaa (genus).
/// NCBI TaxId: 2109705
/// </summary>
public abstract class Chrysopaa : Dicroglossidae, IChrysopaa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysopaa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2109705;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysopaa";

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
