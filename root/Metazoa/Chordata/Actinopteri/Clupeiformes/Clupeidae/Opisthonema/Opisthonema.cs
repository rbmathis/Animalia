using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Opisthonema;

/// <summary>
/// Abstract class for Opisthonema (genus).
/// NCBI TaxId: 224710
/// </summary>
public abstract class Opisthonema : Clupeidae, IOpisthonema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthonema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224710;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthonema";

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
