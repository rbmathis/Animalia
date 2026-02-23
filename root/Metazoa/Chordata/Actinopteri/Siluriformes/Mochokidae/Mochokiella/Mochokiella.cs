using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Mochokiella;

/// <summary>
/// Abstract class for Mochokiella (genus).
/// NCBI TaxId: 1273077
/// </summary>
public abstract class Mochokiella : Mochokidae, IMochokiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mochokiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1273077;

    /// <inheritdoc />
    public virtual string GenusName => "Mochokiella";

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
