using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Narophis;

/// <summary>
/// Abstract class for Narophis (genus).
/// NCBI TaxId: 3148894
/// </summary>
public abstract class Narophis : Elapidae, INarophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Narophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148894;

    /// <inheritdoc />
    public virtual string GenusName => "Narophis";

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
