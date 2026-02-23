using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Dasyurus;

/// <summary>
/// Abstract class for Dasyurus (genus).
/// NCBI TaxId: 9278
/// </summary>
public abstract class Dasyurus : Dasyuridae, IDasyurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasyurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9278;

    /// <inheritdoc />
    public virtual string GenusName => "Dasyurus";

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
