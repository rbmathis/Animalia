using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Eumyias;

/// <summary>
/// Abstract class for Eumyias (genus).
/// NCBI TaxId: 573046
/// </summary>
public abstract class Eumyias : Muscicapidae, IEumyias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumyias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 573046;

    /// <inheritdoc />
    public virtual string GenusName => "Eumyias";

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
