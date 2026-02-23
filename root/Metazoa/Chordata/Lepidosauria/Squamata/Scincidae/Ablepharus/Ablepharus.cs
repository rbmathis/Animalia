using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ablepharus;

/// <summary>
/// Abstract class for Ablepharus (genus).
/// NCBI TaxId: 71012
/// </summary>
public abstract class Ablepharus : Scincidae, IAblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ablepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71012;

    /// <inheritdoc />
    public virtual string GenusName => "Ablepharus";

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
