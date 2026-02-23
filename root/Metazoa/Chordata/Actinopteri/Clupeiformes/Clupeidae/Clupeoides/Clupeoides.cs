using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupeoides;

/// <summary>
/// Abstract class for Clupeoides (genus).
/// NCBI TaxId: 689645
/// </summary>
public abstract class Clupeoides : Clupeidae, IClupeoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupeoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689645;

    /// <inheritdoc />
    public virtual string GenusName => "Clupeoides";

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
