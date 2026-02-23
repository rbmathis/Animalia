using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Muscicapa;

/// <summary>
/// Abstract class for Muscicapa (genus).
/// NCBI TaxId: 69507
/// </summary>
public abstract class Muscicapa : Muscicapidae, IMuscicapa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muscicapa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69507;

    /// <inheritdoc />
    public virtual string GenusName => "Muscicapa";

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
