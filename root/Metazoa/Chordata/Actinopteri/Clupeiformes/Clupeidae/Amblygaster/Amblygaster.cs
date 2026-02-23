using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Amblygaster;

/// <summary>
/// Abstract class for Amblygaster (genus).
/// NCBI TaxId: 392304
/// </summary>
public abstract class Amblygaster : Clupeidae, IAmblygaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblygaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392304;

    /// <inheritdoc />
    public virtual string GenusName => "Amblygaster";

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
