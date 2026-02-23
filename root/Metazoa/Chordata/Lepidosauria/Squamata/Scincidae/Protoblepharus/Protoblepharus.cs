using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Protoblepharus;

/// <summary>
/// Abstract class for Protoblepharus (genus).
/// NCBI TaxId: 2962433
/// </summary>
public abstract class Protoblepharus : Scincidae, IProtoblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protoblepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2962433;

    /// <inheritdoc />
    public virtual string GenusName => "Protoblepharus";

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
