using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Pinarochroa;

/// <summary>
/// Abstract class for Pinarochroa (genus).
/// NCBI TaxId: 2823182
/// </summary>
public abstract class Pinarochroa : Muscicapidae, IPinarochroa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinarochroa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823182;

    /// <inheritdoc />
    public virtual string GenusName => "Pinarochroa";

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
