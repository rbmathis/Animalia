using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Cephalophula;

/// <summary>
/// Abstract class for Cephalophula (genus).
/// NCBI TaxId: 3033999
/// </summary>
public abstract class Cephalophula : Bovidae, ICephalophula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalophula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3033999;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalophula";

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
