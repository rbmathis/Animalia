using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Oenanthe;

/// <summary>
/// Abstract class for Oenanthe (genus).
/// NCBI TaxId: 245059
/// </summary>
public abstract class Oenanthe : Muscicapidae, IOenanthe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oenanthe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245059;

    /// <inheritdoc />
    public virtual string GenusName => "Oenanthe";

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
