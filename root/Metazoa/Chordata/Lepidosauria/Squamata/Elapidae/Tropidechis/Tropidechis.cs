using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Tropidechis;

/// <summary>
/// Abstract class for Tropidechis (genus).
/// NCBI TaxId: 100988
/// </summary>
public abstract class Tropidechis : Elapidae, ITropidechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100988;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidechis";

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
