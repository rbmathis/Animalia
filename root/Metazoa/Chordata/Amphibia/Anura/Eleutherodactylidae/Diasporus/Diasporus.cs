using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Diasporus;

/// <summary>
/// Abstract class for Diasporus (genus).
/// NCBI TaxId: 611779
/// </summary>
public abstract class Diasporus : Eleutherodactylidae, IDiasporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diasporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 611779;

    /// <inheritdoc />
    public virtual string GenusName => "Diasporus";

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
