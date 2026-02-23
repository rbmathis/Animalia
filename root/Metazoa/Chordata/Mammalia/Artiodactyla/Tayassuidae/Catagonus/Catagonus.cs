using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Catagonus;

/// <summary>
/// Abstract class for Catagonus (genus).
/// NCBI TaxId: 51153
/// </summary>
public abstract class Catagonus : Tayassuidae, ICatagonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catagonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51153;

    /// <inheritdoc />
    public virtual string GenusName => "Catagonus";

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
