using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllopezus;

/// <summary>
/// Abstract class for Phyllopezus (genus).
/// NCBI TaxId: 298115
/// </summary>
public abstract class Phyllopezus : Phyllodactylidae, IPhyllopezus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllopezus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 298115;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllopezus";

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
