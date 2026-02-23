using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Metahomaloptera;

/// <summary>
/// Abstract class for Metahomaloptera (genus).
/// NCBI TaxId: 340415
/// </summary>
public abstract class Metahomaloptera : Balitoridae, IMetahomaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metahomaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 340415;

    /// <inheritdoc />
    public virtual string GenusName => "Metahomaloptera";

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
