using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Oedodera;

/// <summary>
/// Abstract class for Oedodera (genus).
/// NCBI TaxId: 311550
/// </summary>
public abstract class Oedodera : Diplodactylidae, IOedodera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oedodera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311550;

    /// <inheritdoc />
    public virtual string GenusName => "Oedodera";

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
