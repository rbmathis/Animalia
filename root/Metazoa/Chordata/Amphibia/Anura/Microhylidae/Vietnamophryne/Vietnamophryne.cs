using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Vietnamophryne;

/// <summary>
/// Abstract class for Vietnamophryne (genus).
/// NCBI TaxId: 2174910
/// </summary>
public abstract class Vietnamophryne : Microhylidae, IVietnamophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vietnamophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2174910;

    /// <inheritdoc />
    public virtual string GenusName => "Vietnamophryne";

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
