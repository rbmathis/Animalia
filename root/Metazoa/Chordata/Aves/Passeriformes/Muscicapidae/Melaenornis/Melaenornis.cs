using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Melaenornis;

/// <summary>
/// Abstract class for Melaenornis (genus).
/// NCBI TaxId: 245055
/// </summary>
public abstract class Melaenornis : Muscicapidae, IMelaenornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melaenornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245055;

    /// <inheritdoc />
    public virtual string GenusName => "Melaenornis";

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
