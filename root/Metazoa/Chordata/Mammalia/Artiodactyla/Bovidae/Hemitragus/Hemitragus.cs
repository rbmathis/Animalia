using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Hemitragus;

/// <summary>
/// Abstract class for Hemitragus (genus).
/// NCBI TaxId: 37178
/// </summary>
public abstract class Hemitragus : Bovidae, IHemitragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37178;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitragus";

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
