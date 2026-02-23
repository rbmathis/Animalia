using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Alces;

/// <summary>
/// Abstract class for Alces (genus).
/// NCBI TaxId: 9851
/// </summary>
public abstract class Alces : Cervidae, IAlces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9851;

    /// <inheritdoc />
    public virtual string GenusName => "Alces";

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
