using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Thamnornis;

/// <summary>
/// Abstract class for Thamnornis (genus).
/// NCBI TaxId: 98153
/// </summary>
public abstract class Thamnornis : Bernieridae, IThamnornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98153;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnornis";

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
