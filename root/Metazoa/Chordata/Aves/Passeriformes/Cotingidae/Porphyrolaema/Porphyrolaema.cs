using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Porphyrolaema;

/// <summary>
/// Abstract class for Porphyrolaema (genus).
/// NCBI TaxId: 114370
/// </summary>
public abstract class Porphyrolaema : Cotingidae, IPorphyrolaema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porphyrolaema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114370;

    /// <inheritdoc />
    public virtual string GenusName => "Porphyrolaema";

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
