using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Spratelloides;

/// <summary>
/// Abstract class for Spratelloides (genus).
/// NCBI TaxId: 365051
/// </summary>
public abstract class Spratelloides : Clupeidae, ISpratelloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spratelloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365051;

    /// <inheritdoc />
    public virtual string GenusName => "Spratelloides";

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
