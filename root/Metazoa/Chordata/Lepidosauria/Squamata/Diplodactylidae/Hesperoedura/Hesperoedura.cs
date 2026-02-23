using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Hesperoedura;

/// <summary>
/// Abstract class for Hesperoedura (genus).
/// NCBI TaxId: 1463603
/// </summary>
public abstract class Hesperoedura : Diplodactylidae, IHesperoedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hesperoedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463603;

    /// <inheritdoc />
    public virtual string GenusName => "Hesperoedura";

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
