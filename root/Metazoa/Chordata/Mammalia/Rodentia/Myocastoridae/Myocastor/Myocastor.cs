using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Myocastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Myocastoridae.Myocastor;

/// <summary>
/// Abstract class for Myocastor (genus).
/// NCBI TaxId: 10156
/// </summary>
public abstract class Myocastor : Myocastoridae, IMyocastor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myocastor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10156;

    /// <inheritdoc />
    public virtual string GenusName => "Myocastor";

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
