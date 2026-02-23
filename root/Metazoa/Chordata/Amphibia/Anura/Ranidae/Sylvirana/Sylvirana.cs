using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Sylvirana;

/// <summary>
/// Abstract class for Sylvirana (genus).
/// NCBI TaxId: 1659747
/// </summary>
public abstract class Sylvirana : Ranidae, ISylvirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylvirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1659747;

    /// <inheritdoc />
    public virtual string GenusName => "Sylvirana";

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
