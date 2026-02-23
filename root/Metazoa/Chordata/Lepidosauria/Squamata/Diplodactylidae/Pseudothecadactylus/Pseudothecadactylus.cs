using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Pseudothecadactylus;

/// <summary>
/// Abstract class for Pseudothecadactylus (genus).
/// NCBI TaxId: 95125
/// </summary>
public abstract class Pseudothecadactylus : Diplodactylidae, IPseudothecadactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudothecadactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95125;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudothecadactylus";

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
