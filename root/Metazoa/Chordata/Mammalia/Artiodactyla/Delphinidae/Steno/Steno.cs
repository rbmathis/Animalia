using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Steno;

/// <summary>
/// Abstract class for Steno (genus).
/// NCBI TaxId: 46166
/// </summary>
public abstract class Steno : Delphinidae, ISteno
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steno";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46166;

    /// <inheritdoc />
    public virtual string GenusName => "Steno";

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
