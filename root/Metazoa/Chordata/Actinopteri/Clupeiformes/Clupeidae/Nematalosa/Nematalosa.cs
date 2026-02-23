using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Nematalosa;

/// <summary>
/// Abstract class for Nematalosa (genus).
/// NCBI TaxId: 316162
/// </summary>
public abstract class Nematalosa : Clupeidae, INematalosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematalosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316162;

    /// <inheritdoc />
    public virtual string GenusName => "Nematalosa";

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
