using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Rucervus;

/// <summary>
/// Abstract class for Rucervus (genus).
/// NCBI TaxId: 1088089
/// </summary>
public abstract class Rucervus : Cervidae, IRucervus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rucervus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1088089;

    /// <inheritdoc />
    public virtual string GenusName => "Rucervus";

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
