using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Sarcophilus;

/// <summary>
/// Abstract class for Sarcophilus (genus).
/// NCBI TaxId: 9304
/// </summary>
public abstract class Sarcophilus : Dasyuridae, ISarcophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9304;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcophilus";

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
