using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

/// <summary>
/// Abstract class for Cervus (genus).
/// NCBI TaxId: 9859
/// </summary>
public abstract class Cervus : Cervidae, ICervus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cervus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9859;

    /// <inheritdoc />
    public virtual string GenusName => "Cervus";

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
