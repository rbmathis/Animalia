using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homaloptera;

/// <summary>
/// Abstract class for Homaloptera (genus).
/// NCBI TaxId: 357283
/// </summary>
public abstract class Homaloptera : Balitoridae, IHomaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 357283;

    /// <inheritdoc />
    public virtual string GenusName => "Homaloptera";

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
