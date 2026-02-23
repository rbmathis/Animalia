using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Rachovia;

/// <summary>
/// Abstract class for Rachovia (genus).
/// NCBI TaxId: 61838
/// </summary>
public abstract class Rachovia : Rivulidae, IRachovia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rachovia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61838;

    /// <inheritdoc />
    public virtual string GenusName => "Rachovia";

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
