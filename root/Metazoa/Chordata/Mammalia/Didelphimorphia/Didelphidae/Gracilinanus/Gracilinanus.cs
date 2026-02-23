using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Gracilinanus;

/// <summary>
/// Abstract class for Gracilinanus (genus).
/// NCBI TaxId: 126288
/// </summary>
public abstract class Gracilinanus : Didelphidae, IGracilinanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracilinanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126288;

    /// <inheritdoc />
    public virtual string GenusName => "Gracilinanus";

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
