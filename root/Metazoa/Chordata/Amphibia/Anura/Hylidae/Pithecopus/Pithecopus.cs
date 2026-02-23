using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pithecopus;

/// <summary>
/// Abstract class for Pithecopus (genus).
/// NCBI TaxId: 1911155
/// </summary>
public abstract class Pithecopus : Hylidae, IPithecopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pithecopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1911155;

    /// <inheritdoc />
    public virtual string GenusName => "Pithecopus";

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
