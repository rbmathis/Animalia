using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Phelsuma;

/// <summary>
/// Abstract class for Phelsuma (genus).
/// NCBI TaxId: 42749
/// </summary>
public abstract class Phelsuma : Gekkonidae, IPhelsuma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phelsuma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42749;

    /// <inheritdoc />
    public virtual string GenusName => "Phelsuma";

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
