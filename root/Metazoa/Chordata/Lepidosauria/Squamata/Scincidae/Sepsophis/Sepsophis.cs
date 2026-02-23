using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sepsophis;

/// <summary>
/// Abstract class for Sepsophis (genus).
/// NCBI TaxId: 1545803
/// </summary>
public abstract class Sepsophis : Scincidae, ISepsophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sepsophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545803;

    /// <inheritdoc />
    public virtual string GenusName => "Sepsophis";

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
