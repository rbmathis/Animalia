using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Mystacornis;

/// <summary>
/// Abstract class for Mystacornis (genus).
/// NCBI TaxId: 98132
/// </summary>
public abstract class Mystacornis : Timaliidae, IMystacornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mystacornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98132;

    /// <inheritdoc />
    public virtual string GenusName => "Mystacornis";

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
