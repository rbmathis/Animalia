using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Thamnaconus;

/// <summary>
/// Abstract class for Thamnaconus (genus).
/// NCBI TaxId: 325628
/// </summary>
public abstract class Thamnaconus : Monacanthidae, IThamnaconus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnaconus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 325628;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnaconus";

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
