using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Cophosaurus;

/// <summary>
/// Abstract class for Cophosaurus (genus).
/// NCBI TaxId: 43587
/// </summary>
public abstract class Cophosaurus : Phrynosomatidae, ICophosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cophosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43587;

    /// <inheritdoc />
    public virtual string GenusName => "Cophosaurus";

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
