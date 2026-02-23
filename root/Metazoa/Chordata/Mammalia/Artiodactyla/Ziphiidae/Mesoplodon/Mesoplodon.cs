using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Mesoplodon;

/// <summary>
/// Abstract class for Mesoplodon (genus).
/// NCBI TaxId: 9757
/// </summary>
public abstract class Mesoplodon : Ziphiidae, IMesoplodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesoplodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9757;

    /// <inheritdoc />
    public virtual string GenusName => "Mesoplodon";

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
