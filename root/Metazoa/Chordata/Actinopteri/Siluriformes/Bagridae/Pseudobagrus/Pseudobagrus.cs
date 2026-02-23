using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Pseudobagrus;

/// <summary>
/// Abstract class for Pseudobagrus (genus).
/// NCBI TaxId: 78872
/// </summary>
public abstract class Pseudobagrus : Bagridae, IPseudobagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78872;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobagrus";

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
