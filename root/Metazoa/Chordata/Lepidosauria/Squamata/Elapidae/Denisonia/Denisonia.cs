using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Denisonia;

/// <summary>
/// Abstract class for Denisonia (genus).
/// NCBI TaxId: 529688
/// </summary>
public abstract class Denisonia : Elapidae, IDenisonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Denisonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529688;

    /// <inheritdoc />
    public virtual string GenusName => "Denisonia";

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
