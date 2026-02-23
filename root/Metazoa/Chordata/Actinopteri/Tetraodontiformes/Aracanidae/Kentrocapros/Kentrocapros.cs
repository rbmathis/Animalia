using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae.Kentrocapros;

/// <summary>
/// Abstract class for Kentrocapros (genus).
/// NCBI TaxId: 384596
/// </summary>
public abstract class Kentrocapros : Aracanidae, IKentrocapros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kentrocapros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 384596;

    /// <inheritdoc />
    public virtual string GenusName => "Kentrocapros";

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
