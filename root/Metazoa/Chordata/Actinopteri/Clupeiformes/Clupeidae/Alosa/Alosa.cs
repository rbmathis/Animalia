using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Alosa;

/// <summary>
/// Abstract class for Alosa (genus).
/// NCBI TaxId: 34772
/// </summary>
public abstract class Alosa : Clupeidae, IAlosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34772;

    /// <inheritdoc />
    public virtual string GenusName => "Alosa";

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
