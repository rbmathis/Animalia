using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Gonialosa;

/// <summary>
/// Abstract class for Gonialosa (genus).
/// NCBI TaxId: 2419767
/// </summary>
public abstract class Gonialosa : Clupeidae, IGonialosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonialosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2419767;

    /// <inheritdoc />
    public virtual string GenusName => "Gonialosa";

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
