using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Nilgiritragus;

/// <summary>
/// Abstract class for Nilgiritragus (genus).
/// NCBI TaxId: 3349690
/// </summary>
public abstract class Nilgiritragus : Bovidae, INilgiritragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nilgiritragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3349690;

    /// <inheritdoc />
    public virtual string GenusName => "Nilgiritragus";

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
