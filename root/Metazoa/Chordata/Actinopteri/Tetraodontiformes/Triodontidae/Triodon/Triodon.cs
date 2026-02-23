using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triodontidae.Triodon;

/// <summary>
/// Abstract class for Triodon (genus).
/// NCBI TaxId: 300226
/// </summary>
public abstract class Triodon : Triodontidae, ITriodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300226;

    /// <inheritdoc />
    public virtual string GenusName => "Triodon";

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
