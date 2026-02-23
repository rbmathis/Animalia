using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Hyelaphus;

/// <summary>
/// Abstract class for Hyelaphus (genus).
/// NCBI TaxId: 2494277
/// </summary>
public abstract class Hyelaphus : Cervidae, IHyelaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyelaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2494277;

    /// <inheritdoc />
    public virtual string GenusName => "Hyelaphus";

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
