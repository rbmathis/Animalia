using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Cheracebus;

/// <summary>
/// Abstract class for Cheracebus (genus).
/// NCBI TaxId: 1812102
/// </summary>
public abstract class Cheracebus : Pitheciidae, ICheracebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheracebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812102;

    /// <inheritdoc />
    public virtual string GenusName => "Cheracebus";

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
