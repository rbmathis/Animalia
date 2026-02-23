using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Rhinomyias;

/// <summary>
/// Abstract class for Rhinomyias (genus).
/// NCBI TaxId: 245064
/// </summary>
public abstract class Rhinomyias : Muscicapidae, IRhinomyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinomyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245064;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinomyias";

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
