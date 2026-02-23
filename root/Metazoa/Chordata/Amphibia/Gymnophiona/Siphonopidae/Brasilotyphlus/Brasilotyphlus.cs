using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Brasilotyphlus;

/// <summary>
/// Abstract class for Brasilotyphlus (genus).
/// NCBI TaxId: 264011
/// </summary>
public abstract class Brasilotyphlus : Siphonopidae, IBrasilotyphlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brasilotyphlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264011;

    /// <inheritdoc />
    public virtual string GenusName => "Brasilotyphlus";

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
