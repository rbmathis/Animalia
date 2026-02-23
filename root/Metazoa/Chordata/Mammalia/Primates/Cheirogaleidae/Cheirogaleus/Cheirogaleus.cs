using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Cheirogaleus;

/// <summary>
/// Abstract class for Cheirogaleus (genus).
/// NCBI TaxId: 9459
/// </summary>
public abstract class Cheirogaleus : Cheirogaleidae, ICheirogaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheirogaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9459;

    /// <inheritdoc />
    public virtual string GenusName => "Cheirogaleus";

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
