using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Polyspina;

/// <summary>
/// Abstract class for Polyspina (genus).
/// NCBI TaxId: 862796
/// </summary>
public abstract class Polyspina : Tetraodontidae, IPolyspina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyspina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862796;

    /// <inheritdoc />
    public virtual string GenusName => "Polyspina";

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
