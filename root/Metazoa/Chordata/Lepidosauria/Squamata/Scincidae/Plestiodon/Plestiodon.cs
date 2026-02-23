using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Plestiodon;

/// <summary>
/// Abstract class for Plestiodon (genus).
/// NCBI TaxId: 391658
/// </summary>
public abstract class Plestiodon : Scincidae, IPlestiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plestiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391658;

    /// <inheritdoc />
    public virtual string GenusName => "Plestiodon";

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
