using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Megalocercus;

/// <summary>
/// Abstract class for Megalocercus (genus).
/// NCBI TaxId: 569449
/// </summary>
public abstract class Megalocercus : Oikopleuridae, IMegalocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 569449;

    /// <inheritdoc />
    public virtual string GenusName => "Megalocercus";

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
