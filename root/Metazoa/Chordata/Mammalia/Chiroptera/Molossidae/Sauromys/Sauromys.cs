using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Sauromys;

/// <summary>
/// Abstract class for Sauromys (genus).
/// NCBI TaxId: 999965
/// </summary>
public abstract class Sauromys : Molossidae, ISauromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sauromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 999965;

    /// <inheritdoc />
    public virtual string GenusName => "Sauromys";

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
