using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Caluromys;

/// <summary>
/// Abstract class for Caluromys (genus).
/// NCBI TaxId: 42712
/// </summary>
public abstract class Caluromys : Didelphidae, ICaluromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caluromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42712;

    /// <inheritdoc />
    public virtual string GenusName => "Caluromys";

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
