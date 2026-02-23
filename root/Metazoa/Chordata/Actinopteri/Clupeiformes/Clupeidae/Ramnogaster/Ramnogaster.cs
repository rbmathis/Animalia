using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Ramnogaster;

/// <summary>
/// Abstract class for Ramnogaster (genus).
/// NCBI TaxId: 864455
/// </summary>
public abstract class Ramnogaster : Clupeidae, IRamnogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramnogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 864455;

    /// <inheritdoc />
    public virtual string GenusName => "Ramnogaster";

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
