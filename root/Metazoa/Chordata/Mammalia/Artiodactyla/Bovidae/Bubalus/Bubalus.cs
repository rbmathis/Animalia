using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bubalus;

/// <summary>
/// Abstract class for Bubalus (genus).
/// NCBI TaxId: 9918
/// </summary>
public abstract class Bubalus : Bovidae, IBubalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bubalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9918;

    /// <inheritdoc />
    public virtual string GenusName => "Bubalus";

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
