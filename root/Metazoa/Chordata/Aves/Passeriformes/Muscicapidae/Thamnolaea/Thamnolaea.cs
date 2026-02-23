using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Thamnolaea;

/// <summary>
/// Abstract class for Thamnolaea (genus).
/// NCBI TaxId: 701081
/// </summary>
public abstract class Thamnolaea : Muscicapidae, IThamnolaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnolaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 701081;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnolaea";

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
