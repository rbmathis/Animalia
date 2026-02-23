using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Monodelphis;

/// <summary>
/// Abstract class for Monodelphis (genus).
/// NCBI TaxId: 13615
/// </summary>
public abstract class Monodelphis : Didelphidae, IMonodelphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monodelphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13615;

    /// <inheritdoc />
    public virtual string GenusName => "Monodelphis";

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
