using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophus;

/// <summary>
/// Abstract class for Cephalophus (genus).
/// NCBI TaxId: 9954
/// </summary>
public abstract class Cephalophus : Bovidae, ICephalophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9954;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalophus";

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
