using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Carphodactylidae.Nephrurus;

/// <summary>
/// Abstract class for Nephrurus (genus).
/// NCBI TaxId: 95116
/// </summary>
public abstract class Nephrurus : Carphodactylidae, INephrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nephrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95116;

    /// <inheritdoc />
    public virtual string GenusName => "Nephrurus";

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
