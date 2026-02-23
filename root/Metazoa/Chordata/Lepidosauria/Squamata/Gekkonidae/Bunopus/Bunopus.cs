using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Bunopus;

/// <summary>
/// Abstract class for Bunopus (genus).
/// NCBI TaxId: 94414
/// </summary>
public abstract class Bunopus : Gekkonidae, IBunopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bunopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94414;

    /// <inheritdoc />
    public virtual string GenusName => "Bunopus";

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
