using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Rhyacornis;

/// <summary>
/// Abstract class for Rhyacornis (genus).
/// NCBI TaxId: 248156
/// </summary>
public abstract class Rhyacornis : Muscicapidae, IRhyacornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyacornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248156;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyacornis";

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
