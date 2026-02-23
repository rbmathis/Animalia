using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Pao;

/// <summary>
/// Abstract class for Pao (genus).
/// NCBI TaxId: 1820602
/// </summary>
public abstract class Pao : Tetraodontidae, IPao
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pao";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1820602;

    /// <inheritdoc />
    public virtual string GenusName => "Pao";

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
