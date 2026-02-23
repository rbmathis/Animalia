using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Hilsa;

/// <summary>
/// Abstract class for Hilsa (genus).
/// NCBI TaxId: 529101
/// </summary>
public abstract class Hilsa : Clupeidae, IHilsa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hilsa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 529101;

    /// <inheritdoc />
    public virtual string GenusName => "Hilsa";

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
