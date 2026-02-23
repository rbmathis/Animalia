using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Membras;

/// <summary>
/// Abstract class for Membras (genus).
/// NCBI TaxId: 370633
/// </summary>
public abstract class Membras : Atherinopsidae, IMembras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Membras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 370633;

    /// <inheritdoc />
    public virtual string GenusName => "Membras";

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
