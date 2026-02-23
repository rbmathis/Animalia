using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Pseudorca;

/// <summary>
/// Abstract class for Pseudorca (genus).
/// NCBI TaxId: 82173
/// </summary>
public abstract class Pseudorca : Delphinidae, IPseudorca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudorca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 82173;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudorca";

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
