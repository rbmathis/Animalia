using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Miniopteridae.Miniopterus;

/// <summary>
/// Abstract class for Miniopterus (genus).
/// NCBI TaxId: 9432
/// </summary>
public abstract class Miniopterus : Miniopteridae, IMiniopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Miniopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9432;

    /// <inheritdoc />
    public virtual string GenusName => "Miniopterus";

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
