using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Caprolagus;

/// <summary>
/// Abstract class for Caprolagus (genus).
/// NCBI TaxId: 235648
/// </summary>
public abstract class Caprolagus : Leporidae, ICaprolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caprolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 235648;

    /// <inheritdoc />
    public virtual string GenusName => "Caprolagus";

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
