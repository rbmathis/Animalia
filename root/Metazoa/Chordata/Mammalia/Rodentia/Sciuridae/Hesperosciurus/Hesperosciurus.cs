using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Hesperosciurus;

/// <summary>
/// Abstract class for Hesperosciurus (genus).
/// NCBI TaxId: 2895724
/// </summary>
public abstract class Hesperosciurus : Sciuridae, IHesperosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hesperosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2895724;

    /// <inheritdoc />
    public virtual string GenusName => "Hesperosciurus";

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
