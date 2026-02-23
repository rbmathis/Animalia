using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Vermicella;

/// <summary>
/// Abstract class for Vermicella (genus).
/// NCBI TaxId: 439936
/// </summary>
public abstract class Vermicella : Elapidae, IVermicella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vermicella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 439936;

    /// <inheritdoc />
    public virtual string GenusName => "Vermicella";

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
