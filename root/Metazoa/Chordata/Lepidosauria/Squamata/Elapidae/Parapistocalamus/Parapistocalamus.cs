using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Parapistocalamus;

/// <summary>
/// Abstract class for Parapistocalamus (genus).
/// NCBI TaxId: 1545054
/// </summary>
public abstract class Parapistocalamus : Elapidae, IParapistocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parapistocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545054;

    /// <inheritdoc />
    public virtual string GenusName => "Parapistocalamus";

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
