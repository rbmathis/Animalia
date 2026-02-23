using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Sminthopsis;

/// <summary>
/// Abstract class for Sminthopsis (genus).
/// NCBI TaxId: 9300
/// </summary>
public abstract class Sminthopsis : Dasyuridae, ISminthopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sminthopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9300;

    /// <inheritdoc />
    public virtual string GenusName => "Sminthopsis";

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
