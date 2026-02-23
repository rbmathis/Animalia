using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Ophisaurus;

/// <summary>
/// Abstract class for Ophisaurus (genus).
/// NCBI TaxId: 102190
/// </summary>
public abstract class Ophisaurus : Anguidae, IOphisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 102190;

    /// <inheritdoc />
    public virtual string GenusName => "Ophisaurus";

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
