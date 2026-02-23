using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Ololygon;

/// <summary>
/// Abstract class for Ololygon (genus).
/// NCBI TaxId: 1911122
/// </summary>
public abstract class Ololygon : Hylidae, IOlolygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ololygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1911122;

    /// <inheritdoc />
    public virtual string GenusName => "Ololygon";

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
