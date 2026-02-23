using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Ophiodes;

/// <summary>
/// Abstract class for Ophiodes (genus).
/// NCBI TaxId: 102188
/// </summary>
public abstract class Ophiodes : Diploglossidae, IOphiodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophiodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 102188;

    /// <inheritdoc />
    public virtual string GenusName => "Ophiodes";

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
