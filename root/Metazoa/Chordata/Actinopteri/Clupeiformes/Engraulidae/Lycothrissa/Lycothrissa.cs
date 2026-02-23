using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Lycothrissa;

/// <summary>
/// Abstract class for Lycothrissa (genus).
/// NCBI TaxId: 495047
/// </summary>
public abstract class Lycothrissa : Engraulidae, ILycothrissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycothrissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495047;

    /// <inheritdoc />
    public virtual string GenusName => "Lycothrissa";

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
