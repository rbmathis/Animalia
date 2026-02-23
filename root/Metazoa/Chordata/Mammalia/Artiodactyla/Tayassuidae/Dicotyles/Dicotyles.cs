using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Dicotyles;

/// <summary>
/// Abstract class for Dicotyles (genus).
/// NCBI TaxId: 3136298
/// </summary>
public abstract class Dicotyles : Tayassuidae, IDicotyles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicotyles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3136298;

    /// <inheritdoc />
    public virtual string GenusName => "Dicotyles";

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
