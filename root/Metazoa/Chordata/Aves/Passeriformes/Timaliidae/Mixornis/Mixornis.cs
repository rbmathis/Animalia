using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Mixornis;

/// <summary>
/// Abstract class for Mixornis (genus).
/// NCBI TaxId: 1948885
/// </summary>
public abstract class Mixornis : Timaliidae, IMixornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mixornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1948885;

    /// <inheritdoc />
    public virtual string GenusName => "Mixornis";

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
