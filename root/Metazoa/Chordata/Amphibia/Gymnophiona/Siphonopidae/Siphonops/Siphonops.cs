using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Siphonops;

/// <summary>
/// Abstract class for Siphonops (genus).
/// NCBI TaxId: 264019
/// </summary>
public abstract class Siphonops : Siphonopidae, ISiphonops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siphonops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264019;

    /// <inheritdoc />
    public virtual string GenusName => "Siphonops";

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
