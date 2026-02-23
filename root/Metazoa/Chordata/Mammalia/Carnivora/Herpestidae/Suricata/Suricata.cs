using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Suricata;

/// <summary>
/// Abstract class for Suricata (genus).
/// NCBI TaxId: 37031
/// </summary>
public abstract class Suricata : Herpestidae, ISuricata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suricata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37031;

    /// <inheritdoc />
    public virtual string GenusName => "Suricata";

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
