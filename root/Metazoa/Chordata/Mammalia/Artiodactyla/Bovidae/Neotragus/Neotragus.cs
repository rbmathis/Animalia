using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Neotragus;

/// <summary>
/// Abstract class for Neotragus (genus).
/// NCBI TaxId: 66441
/// </summary>
public abstract class Neotragus : Bovidae, INeotragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neotragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66441;

    /// <inheritdoc />
    public virtual string GenusName => "Neotragus";

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
