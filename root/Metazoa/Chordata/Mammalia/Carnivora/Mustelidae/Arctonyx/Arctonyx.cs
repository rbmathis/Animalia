using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Arctonyx;

/// <summary>
/// Abstract class for Arctonyx (genus).
/// NCBI TaxId: 139308
/// </summary>
public abstract class Arctonyx : Mustelidae, IArctonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arctonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 139308;

    /// <inheritdoc />
    public virtual string GenusName => "Arctonyx";

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
