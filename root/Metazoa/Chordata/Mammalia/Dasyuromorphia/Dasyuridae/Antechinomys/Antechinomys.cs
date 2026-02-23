using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Antechinomys;

/// <summary>
/// Abstract class for Antechinomys (genus).
/// NCBI TaxId: 60700
/// </summary>
public abstract class Antechinomys : Dasyuridae, IAntechinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antechinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60700;

    /// <inheritdoc />
    public virtual string GenusName => "Antechinomys";

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
