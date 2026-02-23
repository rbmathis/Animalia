using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mystacinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Mystacinidae.Mystacina;

/// <summary>
/// Abstract class for Mystacina (genus).
/// NCBI TaxId: 94960
/// </summary>
public abstract class Mystacina : Mystacinidae, IMystacina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mystacina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94960;

    /// <inheritdoc />
    public virtual string GenusName => "Mystacina";

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
