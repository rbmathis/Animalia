using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Blastocerus;

/// <summary>
/// Abstract class for Blastocerus (genus).
/// NCBI TaxId: 248132
/// </summary>
public abstract class Blastocerus : Cervidae, IBlastocerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blastocerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248132;

    /// <inheritdoc />
    public virtual string GenusName => "Blastocerus";

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
