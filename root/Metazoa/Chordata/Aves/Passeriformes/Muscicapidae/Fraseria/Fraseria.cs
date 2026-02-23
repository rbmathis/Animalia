using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Fraseria;

/// <summary>
/// Abstract class for Fraseria (genus).
/// NCBI TaxId: 570448
/// </summary>
public abstract class Fraseria : Muscicapidae, IFraseria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fraseria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 570448;

    /// <inheritdoc />
    public virtual string GenusName => "Fraseria";

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
