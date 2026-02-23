using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Sandyrana;

/// <summary>
/// Abstract class for Sandyrana (genus).
/// NCBI TaxId: 3681007
/// </summary>
public abstract class Sandyrana : Pelodryadidae, ISandyrana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sandyrana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681007;

    /// <inheritdoc />
    public virtual string GenusName => "Sandyrana";

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
