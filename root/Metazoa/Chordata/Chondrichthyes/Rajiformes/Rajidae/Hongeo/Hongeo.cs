using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Hongeo;

/// <summary>
/// Abstract class for Hongeo (genus).
/// NCBI TaxId: 1352415
/// </summary>
public abstract class Hongeo : Rajidae, IHongeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hongeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1352415;

    /// <inheritdoc />
    public virtual string GenusName => "Hongeo";

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
