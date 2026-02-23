using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Tylerius;

/// <summary>
/// Abstract class for Tylerius (genus).
/// NCBI TaxId: 862804
/// </summary>
public abstract class Tylerius : Tetraodontidae, ITylerius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylerius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862804;

    /// <inheritdoc />
    public virtual string GenusName => "Tylerius";

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
