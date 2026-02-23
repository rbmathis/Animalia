using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Cheiromeles;

/// <summary>
/// Abstract class for Cheiromeles (genus).
/// NCBI TaxId: 270767
/// </summary>
public abstract class Cheiromeles : Molossidae, ICheiromeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheiromeles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270767;

    /// <inheritdoc />
    public virtual string GenusName => "Cheiromeles";

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
