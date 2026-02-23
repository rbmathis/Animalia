using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Arothron;

/// <summary>
/// Abstract class for Arothron (genus).
/// NCBI TaxId: 50368
/// </summary>
public abstract class Arothron : Tetraodontidae, IArothron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arothron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50368;

    /// <inheritdoc />
    public virtual string GenusName => "Arothron";

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
