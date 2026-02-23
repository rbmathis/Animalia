using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Plecturocebus;

/// <summary>
/// Abstract class for Plecturocebus (genus).
/// NCBI TaxId: 1812035
/// </summary>
public abstract class Plecturocebus : Pitheciidae, IPlecturocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plecturocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1812035;

    /// <inheritdoc />
    public virtual string GenusName => "Plecturocebus";

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
