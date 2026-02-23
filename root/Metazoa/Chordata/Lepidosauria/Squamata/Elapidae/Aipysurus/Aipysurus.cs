using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Aipysurus;

/// <summary>
/// Abstract class for Aipysurus (genus).
/// NCBI TaxId: 8677
/// </summary>
public abstract class Aipysurus : Elapidae, IAipysurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aipysurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8677;

    /// <inheritdoc />
    public virtual string GenusName => "Aipysurus";

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
