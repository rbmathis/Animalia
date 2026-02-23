using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Rhinosciurus;

/// <summary>
/// Abstract class for Rhinosciurus (genus).
/// NCBI TaxId: 226570
/// </summary>
public abstract class Rhinosciurus : Sciuridae, IRhinosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226570;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinosciurus";

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
