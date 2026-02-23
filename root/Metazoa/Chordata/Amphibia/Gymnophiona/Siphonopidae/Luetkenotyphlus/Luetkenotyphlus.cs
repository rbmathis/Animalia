using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Luetkenotyphlus;

/// <summary>
/// Abstract class for Luetkenotyphlus (genus).
/// NCBI TaxId: 264016
/// </summary>
public abstract class Luetkenotyphlus : Siphonopidae, ILuetkenotyphlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luetkenotyphlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264016;

    /// <inheritdoc />
    public virtual string GenusName => "Luetkenotyphlus";

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
