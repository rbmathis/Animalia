using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Murexia;

/// <summary>
/// Abstract class for Murexia (genus).
/// NCBI TaxId: 9288
/// </summary>
public abstract class Murexia : Dasyuridae, IMurexia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Murexia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9288;

    /// <inheritdoc />
    public virtual string GenusName => "Murexia";

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
