using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Tenualosa;

/// <summary>
/// Abstract class for Tenualosa (genus).
/// NCBI TaxId: 248134
/// </summary>
public abstract class Tenualosa : Clupeidae, ITenualosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tenualosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248134;

    /// <inheritdoc />
    public virtual string GenusName => "Tenualosa";

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
