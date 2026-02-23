using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Potamochoerus;

/// <summary>
/// Abstract class for Potamochoerus (genus).
/// NCBI TaxId: 273790
/// </summary>
public abstract class Potamochoerus : Suidae, IPotamochoerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamochoerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 273790;

    /// <inheritdoc />
    public virtual string GenusName => "Potamochoerus";

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
