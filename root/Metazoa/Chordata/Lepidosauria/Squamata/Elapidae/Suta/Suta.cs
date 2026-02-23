using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Suta;

/// <summary>
/// Abstract class for Suta (genus).
/// NCBI TaxId: 505431
/// </summary>
public abstract class Suta : Elapidae, ISuta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 505431;

    /// <inheritdoc />
    public virtual string GenusName => "Suta";

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
