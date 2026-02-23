using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Genyophryne;

/// <summary>
/// Abstract class for Genyophryne (genus).
/// NCBI TaxId: 356296
/// </summary>
public abstract class Genyophryne : Microhylidae, IGenyophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genyophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356296;

    /// <inheritdoc />
    public virtual string GenusName => "Genyophryne";

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
