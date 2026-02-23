using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Aepyceros;

/// <summary>
/// Abstract class for Aepyceros (genus).
/// NCBI TaxId: 9896
/// </summary>
public abstract class Aepyceros : Bovidae, IAepyceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aepyceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9896;

    /// <inheritdoc />
    public virtual string GenusName => "Aepyceros";

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
