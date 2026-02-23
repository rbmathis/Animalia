using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Amalosia;

/// <summary>
/// Abstract class for Amalosia (genus).
/// NCBI TaxId: 1336433
/// </summary>
public abstract class Amalosia : Diplodactylidae, IAmalosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amalosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1336433;

    /// <inheritdoc />
    public virtual string GenusName => "Amalosia";

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
