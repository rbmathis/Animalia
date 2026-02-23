using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan;

/// <summary>
/// Abstract class for Pan (genus).
/// NCBI TaxId: 9596
/// </summary>
public abstract class Pan : Hominidae, IPan
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pan";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9596;

    /// <inheritdoc />
    public virtual string GenusName => "Pan";

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
