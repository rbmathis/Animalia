using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Sphenophryne;

/// <summary>
/// Abstract class for Sphenophryne (genus).
/// NCBI TaxId: 326988
/// </summary>
public abstract class Sphenophryne : Microhylidae, ISphenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326988;

    /// <inheritdoc />
    public virtual string GenusName => "Sphenophryne";

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
