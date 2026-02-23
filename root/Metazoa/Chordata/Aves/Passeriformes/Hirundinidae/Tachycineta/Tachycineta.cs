using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Tachycineta;

/// <summary>
/// Abstract class for Tachycineta (genus).
/// NCBI TaxId: 72872
/// </summary>
public abstract class Tachycineta : Hirundinidae, ITachycineta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachycineta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72872;

    /// <inheritdoc />
    public virtual string GenusName => "Tachycineta";

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
