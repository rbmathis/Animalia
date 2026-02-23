using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ristella;

/// <summary>
/// Abstract class for Ristella (genus).
/// NCBI TaxId: 245672
/// </summary>
public abstract class Ristella : Scincidae, IRistella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ristella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245672;

    /// <inheritdoc />
    public virtual string GenusName => "Ristella";

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
