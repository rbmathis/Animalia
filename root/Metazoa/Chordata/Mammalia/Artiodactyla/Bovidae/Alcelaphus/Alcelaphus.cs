using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Alcelaphus;

/// <summary>
/// Abstract class for Alcelaphus (genus).
/// NCBI TaxId: 59516
/// </summary>
public abstract class Alcelaphus : Bovidae, IAlcelaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alcelaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59516;

    /// <inheritdoc />
    public virtual string GenusName => "Alcelaphus";

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
