using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Lipogenys;

/// <summary>
/// Abstract class for Lipogenys (genus).
/// NCBI TaxId: 1675538
/// </summary>
public abstract class Lipogenys : Notacanthidae, ILipogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1675538;

    /// <inheritdoc />
    public virtual string GenusName => "Lipogenys";

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
