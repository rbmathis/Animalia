using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ammotragus;

/// <summary>
/// Abstract class for Ammotragus (genus).
/// NCBI TaxId: 9898
/// </summary>
public abstract class Ammotragus : Bovidae, IAmmotragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammotragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9898;

    /// <inheritdoc />
    public virtual string GenusName => "Ammotragus";

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
