using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Hippotragus;

/// <summary>
/// Abstract class for Hippotragus (genus).
/// NCBI TaxId: 37184
/// </summary>
public abstract class Hippotragus : Bovidae, IHippotragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippotragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37184;

    /// <inheritdoc />
    public virtual string GenusName => "Hippotragus";

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
