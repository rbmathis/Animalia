using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Dasyprocta;

/// <summary>
/// Abstract class for Dasyprocta (genus).
/// NCBI TaxId: 34845
/// </summary>
public abstract class Dasyprocta : Dasyproctidae, IDasyprocta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasyprocta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34845;

    /// <inheritdoc />
    public virtual string GenusName => "Dasyprocta";

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
