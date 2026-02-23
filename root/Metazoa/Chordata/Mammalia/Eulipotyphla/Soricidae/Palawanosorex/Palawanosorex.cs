using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Palawanosorex;

/// <summary>
/// Abstract class for Palawanosorex (genus).
/// NCBI TaxId: 2591605
/// </summary>
public abstract class Palawanosorex : Soricidae, IPalawanosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palawanosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2591605;

    /// <inheritdoc />
    public virtual string GenusName => "Palawanosorex";

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
