using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Escualosa;

/// <summary>
/// Abstract class for Escualosa (genus).
/// NCBI TaxId: 454031
/// </summary>
public abstract class Escualosa : Clupeidae, IEscualosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Escualosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 454031;

    /// <inheritdoc />
    public virtual string GenusName => "Escualosa";

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
