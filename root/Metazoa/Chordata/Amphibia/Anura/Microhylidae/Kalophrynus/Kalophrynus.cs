using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Kalophrynus;

/// <summary>
/// Abstract class for Kalophrynus (genus).
/// NCBI TaxId: 326975
/// </summary>
public abstract class Kalophrynus : Microhylidae, IKalophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kalophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326975;

    /// <inheritdoc />
    public virtual string GenusName => "Kalophrynus";

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
