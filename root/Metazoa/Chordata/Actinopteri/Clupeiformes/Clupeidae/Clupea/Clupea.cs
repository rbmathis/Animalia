using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupea;

/// <summary>
/// Abstract class for Clupea (genus).
/// NCBI TaxId: 7949
/// </summary>
public abstract class Clupea : Clupeidae, IClupea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7949;

    /// <inheritdoc />
    public virtual string GenusName => "Clupea";

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
