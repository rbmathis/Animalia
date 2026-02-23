using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Ellochelon;

/// <summary>
/// Abstract class for Ellochelon (genus).
/// NCBI TaxId: 1111474
/// </summary>
public abstract class Ellochelon : Mugilidae, IEllochelon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ellochelon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1111474;

    /// <inheritdoc />
    public virtual string GenusName => "Ellochelon";

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
