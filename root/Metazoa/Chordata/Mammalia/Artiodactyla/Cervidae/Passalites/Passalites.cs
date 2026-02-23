using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Passalites;

/// <summary>
/// Abstract class for Passalites (genus).
/// NCBI TaxId: 3060158
/// </summary>
public abstract class Passalites : Cervidae, IPassalites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Passalites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3060158;

    /// <inheritdoc />
    public virtual string GenusName => "Passalites";

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
