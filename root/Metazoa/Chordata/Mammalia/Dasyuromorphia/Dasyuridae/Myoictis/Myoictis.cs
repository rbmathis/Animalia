using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Myoictis;

/// <summary>
/// Abstract class for Myoictis (genus).
/// NCBI TaxId: 32548
/// </summary>
public abstract class Myoictis : Dasyuridae, IMyoictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myoictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32548;

    /// <inheritdoc />
    public virtual string GenusName => "Myoictis";

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
