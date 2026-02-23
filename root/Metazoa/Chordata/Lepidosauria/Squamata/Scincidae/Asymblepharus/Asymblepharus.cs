using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Asymblepharus;

/// <summary>
/// Abstract class for Asymblepharus (genus).
/// NCBI TaxId: 273659
/// </summary>
public abstract class Asymblepharus : Scincidae, IAsymblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asymblepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 273659;

    /// <inheritdoc />
    public virtual string GenusName => "Asymblepharus";

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
