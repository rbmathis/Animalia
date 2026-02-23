using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Anodontostoma;

/// <summary>
/// Abstract class for Anodontostoma (genus).
/// NCBI TaxId: 604078
/// </summary>
public abstract class Anodontostoma : Clupeidae, IAnodontostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anodontostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 604078;

    /// <inheritdoc />
    public virtual string GenusName => "Anodontostoma";

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
