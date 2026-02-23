using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sundasalanx;

/// <summary>
/// Abstract class for Sundasalanx (genus).
/// NCBI TaxId: 221868
/// </summary>
public abstract class Sundasalanx : Clupeidae, ISundasalanx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sundasalanx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221868;

    /// <inheritdoc />
    public virtual string GenusName => "Sundasalanx";

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
