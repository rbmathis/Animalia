using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophorus;

/// <summary>
/// Abstract class for Cephalophorus (genus).
/// NCBI TaxId: 3026943
/// </summary>
public abstract class Cephalophorus : Bovidae, ICephalophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3026943;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalophorus";

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
