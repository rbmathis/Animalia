using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Boselaphus;

/// <summary>
/// Abstract class for Boselaphus (genus).
/// NCBI TaxId: 9916
/// </summary>
public abstract class Boselaphus : Bovidae, IBoselaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boselaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9916;

    /// <inheritdoc />
    public virtual string GenusName => "Boselaphus";

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
