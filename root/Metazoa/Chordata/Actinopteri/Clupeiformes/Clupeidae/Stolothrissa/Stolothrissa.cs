using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Stolothrissa;

/// <summary>
/// Abstract class for Stolothrissa (genus).
/// NCBI TaxId: 55121
/// </summary>
public abstract class Stolothrissa : Clupeidae, IStolothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stolothrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55121;

    /// <inheritdoc />
    public virtual string GenusName => "Stolothrissa";

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
