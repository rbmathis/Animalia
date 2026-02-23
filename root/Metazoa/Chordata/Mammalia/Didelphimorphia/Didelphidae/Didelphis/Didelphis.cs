using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis;

/// <summary>
/// Abstract class for Didelphis (genus).
/// NCBI TaxId: 9266
/// </summary>
public abstract class Didelphis : Didelphidae, IDidelphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Didelphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9266;

    /// <inheritdoc />
    public virtual string GenusName => "Didelphis";

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
