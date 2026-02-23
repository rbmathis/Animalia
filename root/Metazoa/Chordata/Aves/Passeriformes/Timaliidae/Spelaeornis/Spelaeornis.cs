using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Spelaeornis;

/// <summary>
/// Abstract class for Spelaeornis (genus).
/// NCBI TaxId: 202234
/// </summary>
public abstract class Spelaeornis : Timaliidae, ISpelaeornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spelaeornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202234;

    /// <inheritdoc />
    public virtual string GenusName => "Spelaeornis";

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
