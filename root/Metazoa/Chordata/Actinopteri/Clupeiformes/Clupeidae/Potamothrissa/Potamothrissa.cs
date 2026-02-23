using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Potamothrissa;

/// <summary>
/// Abstract class for Potamothrissa (genus).
/// NCBI TaxId: 521035
/// </summary>
public abstract class Potamothrissa : Clupeidae, IPotamothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamothrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521035;

    /// <inheritdoc />
    public virtual string GenusName => "Potamothrissa";

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
