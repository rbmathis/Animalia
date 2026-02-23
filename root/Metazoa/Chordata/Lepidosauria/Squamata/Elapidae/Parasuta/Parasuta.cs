using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Parasuta;

/// <summary>
/// Abstract class for Parasuta (genus).
/// NCBI TaxId: 1353233
/// </summary>
public abstract class Parasuta : Elapidae, IParasuta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parasuta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1353233;

    /// <inheritdoc />
    public virtual string GenusName => "Parasuta";

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
