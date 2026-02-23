using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Chalcorana;

/// <summary>
/// Abstract class for Chalcorana (genus).
/// NCBI TaxId: 2786935
/// </summary>
public abstract class Chalcorana : Ranidae, IChalcorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2786935;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcorana";

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
