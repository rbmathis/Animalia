using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micruroides;

/// <summary>
/// Abstract class for Micruroides (genus).
/// NCBI TaxId: 39079
/// </summary>
public abstract class Micruroides : Elapidae, IMicruroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micruroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39079;

    /// <inheritdoc />
    public virtual string GenusName => "Micruroides";

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
