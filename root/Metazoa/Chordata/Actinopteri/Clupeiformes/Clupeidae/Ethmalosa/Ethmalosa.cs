using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Ethmalosa;

/// <summary>
/// Abstract class for Ethmalosa (genus).
/// NCBI TaxId: 297797
/// </summary>
public abstract class Ethmalosa : Clupeidae, IEthmalosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ethmalosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 297797;

    /// <inheritdoc />
    public virtual string GenusName => "Ethmalosa";

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
