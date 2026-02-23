using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Rhombophryne;

/// <summary>
/// Abstract class for Rhombophryne (genus).
/// NCBI TaxId: 289204
/// </summary>
public abstract class Rhombophryne : Microhylidae, IRhombophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhombophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 289204;

    /// <inheritdoc />
    public virtual string GenusName => "Rhombophryne";

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
