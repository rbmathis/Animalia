using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Micropechis;

/// <summary>
/// Abstract class for Micropechis (genus).
/// NCBI TaxId: 66187
/// </summary>
public abstract class Micropechis : Elapidae, IMicropechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66187;

    /// <inheritdoc />
    public virtual string GenusName => "Micropechis";

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
