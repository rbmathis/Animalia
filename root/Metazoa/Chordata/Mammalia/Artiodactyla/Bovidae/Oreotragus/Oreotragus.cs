using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oreotragus;

/// <summary>
/// Abstract class for Oreotragus (genus).
/// NCBI TaxId: 66443
/// </summary>
public abstract class Oreotragus : Bovidae, IOreotragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreotragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66443;

    /// <inheritdoc />
    public virtual string GenusName => "Oreotragus";

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
