using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Heliobolus;

/// <summary>
/// Abstract class for Heliobolus (genus).
/// NCBI TaxId: 71689
/// </summary>
public abstract class Heliobolus : Lacertidae, IHeliobolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliobolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71689;

    /// <inheritdoc />
    public virtual string GenusName => "Heliobolus";

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
