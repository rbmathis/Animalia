using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Platanistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Platanistidae.Platanista;

/// <summary>
/// Abstract class for Platanista (genus).
/// NCBI TaxId: 48750
/// </summary>
public abstract class Platanista : Platanistidae, IPlatanista
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platanista";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48750;

    /// <inheritdoc />
    public virtual string GenusName => "Platanista";

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
