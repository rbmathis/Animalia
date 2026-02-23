using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Parantechinus;

/// <summary>
/// Abstract class for Parantechinus (genus).
/// NCBI TaxId: 9290
/// </summary>
public abstract class Parantechinus : Dasyuridae, IParantechinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parantechinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9290;

    /// <inheritdoc />
    public virtual string GenusName => "Parantechinus";

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
