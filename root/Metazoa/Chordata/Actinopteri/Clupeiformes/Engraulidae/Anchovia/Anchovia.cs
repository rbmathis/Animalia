using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Anchovia;

/// <summary>
/// Abstract class for Anchovia (genus).
/// NCBI TaxId: 495041
/// </summary>
public abstract class Anchovia : Engraulidae, IAnchovia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anchovia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495041;

    /// <inheritdoc />
    public virtual string GenusName => "Anchovia";

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
