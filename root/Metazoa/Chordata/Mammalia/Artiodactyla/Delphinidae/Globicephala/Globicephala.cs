using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Globicephala;

/// <summary>
/// Abstract class for Globicephala (genus).
/// NCBI TaxId: 9729
/// </summary>
public abstract class Globicephala : Delphinidae, IGlobicephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Globicephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9729;

    /// <inheritdoc />
    public virtual string GenusName => "Globicephala";

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
