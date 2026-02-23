using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pulchrana;

/// <summary>
/// Abstract class for Pulchrana (genus).
/// NCBI TaxId: 1659745
/// </summary>
public abstract class Pulchrana : Ranidae, IPulchrana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pulchrana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1659745;

    /// <inheritdoc />
    public virtual string GenusName => "Pulchrana";

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
