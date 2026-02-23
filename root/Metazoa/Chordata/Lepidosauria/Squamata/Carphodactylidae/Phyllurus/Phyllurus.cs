using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Phyllurus;

/// <summary>
/// Abstract class for Phyllurus (genus).
/// NCBI TaxId: 136855
/// </summary>
public abstract class Phyllurus : Carphodactylidae, IPhyllurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136855;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllurus";

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
