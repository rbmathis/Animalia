using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Neofelis;

/// <summary>
/// Abstract class for Neofelis (genus).
/// NCBI TaxId: 61451
/// </summary>
public abstract class Neofelis : Felidae, INeofelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neofelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61451;

    /// <inheritdoc />
    public virtual string GenusName => "Neofelis";

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
