using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Paradoxornis;

/// <summary>
/// Abstract class for Paradoxornis (genus).
/// NCBI TaxId: 201370
/// </summary>
public abstract class Paradoxornis : Muscicapidae, IParadoxornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradoxornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201370;

    /// <inheritdoc />
    public virtual string GenusName => "Paradoxornis";

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
