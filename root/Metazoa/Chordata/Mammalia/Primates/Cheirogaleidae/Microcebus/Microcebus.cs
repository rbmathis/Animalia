using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Microcebus;

/// <summary>
/// Abstract class for Microcebus (genus).
/// NCBI TaxId: 13149
/// </summary>
public abstract class Microcebus : Cheirogaleidae, IMicrocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13149;

    /// <inheritdoc />
    public virtual string GenusName => "Microcebus";

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
