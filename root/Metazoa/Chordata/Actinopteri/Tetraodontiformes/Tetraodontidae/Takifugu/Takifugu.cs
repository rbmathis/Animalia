using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Takifugu;

/// <summary>
/// Abstract class for Takifugu (genus).
/// NCBI TaxId: 31032
/// </summary>
public abstract class Takifugu : Tetraodontidae, ITakifugu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Takifugu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 31032;

    /// <inheritdoc />
    public virtual string GenusName => "Takifugu";

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
