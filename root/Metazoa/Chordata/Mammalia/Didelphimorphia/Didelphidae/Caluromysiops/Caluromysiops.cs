using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Caluromysiops;

/// <summary>
/// Abstract class for Caluromysiops (genus).
/// NCBI TaxId: 126285
/// </summary>
public abstract class Caluromysiops : Didelphidae, ICaluromysiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caluromysiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126285;

    /// <inheritdoc />
    public virtual string GenusName => "Caluromysiops";

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
