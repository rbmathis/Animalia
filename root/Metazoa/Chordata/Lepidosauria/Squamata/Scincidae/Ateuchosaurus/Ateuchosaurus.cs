using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ateuchosaurus;

/// <summary>
/// Abstract class for Ateuchosaurus (genus).
/// NCBI TaxId: 316452
/// </summary>
public abstract class Ateuchosaurus : Scincidae, IAteuchosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ateuchosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316452;

    /// <inheritdoc />
    public virtual string GenusName => "Ateuchosaurus";

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
