using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Bathochordaeus;

/// <summary>
/// Abstract class for Bathochordaeus (genus).
/// NCBI TaxId: 1881883
/// </summary>
public abstract class Bathochordaeus : Oikopleuridae, IBathochordaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathochordaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1881883;

    /// <inheritdoc />
    public virtual string GenusName => "Bathochordaeus";

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
