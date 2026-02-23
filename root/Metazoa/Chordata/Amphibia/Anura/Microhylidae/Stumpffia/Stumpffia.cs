using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stumpffia;

/// <summary>
/// Abstract class for Stumpffia (genus).
/// NCBI TaxId: 143649
/// </summary>
public abstract class Stumpffia : Microhylidae, IStumpffia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stumpffia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143649;

    /// <inheritdoc />
    public virtual string GenusName => "Stumpffia";

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
