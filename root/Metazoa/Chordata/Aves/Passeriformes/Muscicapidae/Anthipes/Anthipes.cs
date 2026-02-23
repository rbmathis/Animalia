using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Anthipes;

/// <summary>
/// Abstract class for Anthipes (genus).
/// NCBI TaxId: 2744972
/// </summary>
public abstract class Anthipes : Muscicapidae, IAnthipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2744972;

    /// <inheritdoc />
    public virtual string GenusName => "Anthipes";

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
