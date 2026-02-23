using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardina;

/// <summary>
/// Abstract class for Sardina (genus).
/// NCBI TaxId: 27696
/// </summary>
public abstract class Sardina : Clupeidae, ISardina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sardina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27696;

    /// <inheritdoc />
    public virtual string GenusName => "Sardina";

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
