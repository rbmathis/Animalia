using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Potamalosa;

/// <summary>
/// Abstract class for Potamalosa (genus).
/// NCBI TaxId: 689652
/// </summary>
public abstract class Potamalosa : Clupeidae, IPotamalosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamalosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689652;

    /// <inheritdoc />
    public virtual string GenusName => "Potamalosa";

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
