using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Myoprocta;

/// <summary>
/// Abstract class for Myoprocta (genus).
/// NCBI TaxId: 43317
/// </summary>
public abstract class Myoprocta : Dasyproctidae, IMyoprocta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myoprocta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43317;

    /// <inheritdoc />
    public virtual string GenusName => "Myoprocta";

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
