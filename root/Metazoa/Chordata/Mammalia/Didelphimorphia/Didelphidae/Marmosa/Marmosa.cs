using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa;

/// <summary>
/// Abstract class for Marmosa (genus).
/// NCBI TaxId: 9269
/// </summary>
public abstract class Marmosa : Didelphidae, IMarmosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marmosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9269;

    /// <inheritdoc />
    public virtual string GenusName => "Marmosa";

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
