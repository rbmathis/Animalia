using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Bavayia;

/// <summary>
/// Abstract class for Bavayia (genus).
/// NCBI TaxId: 143556
/// </summary>
public abstract class Bavayia : Diplodactylidae, IBavayia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bavayia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143556;

    /// <inheritdoc />
    public virtual string GenusName => "Bavayia";

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
