using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Oedura;

/// <summary>
/// Abstract class for Oedura (genus).
/// NCBI TaxId: 95119
/// </summary>
public abstract class Oedura : Diplodactylidae, IOedura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oedura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95119;

    /// <inheritdoc />
    public virtual string GenusName => "Oedura";

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
