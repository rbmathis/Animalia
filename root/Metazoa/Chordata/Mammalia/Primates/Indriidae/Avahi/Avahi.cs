using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Abstract class for Avahi (genus).
/// NCBI TaxId: 122245
/// </summary>
public abstract class Avahi : Indriidae, IAvahi
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Avahi";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 122245;

    /// <inheritdoc />
    public virtual string GenusName => "Avahi";

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
