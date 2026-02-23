using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Otophryne;

/// <summary>
/// Abstract class for Otophryne (genus).
/// NCBI TaxId: 445154
/// </summary>
public abstract class Otophryne : Microhylidae, IOtophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445154;

    /// <inheritdoc />
    public virtual string GenusName => "Otophryne";

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
