using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Monopenchelys;

/// <summary>
/// Abstract class for Monopenchelys (genus).
/// NCBI TaxId: 1182257
/// </summary>
public abstract class Monopenchelys : Muraenidae, IMonopenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monopenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182257;

    /// <inheritdoc />
    public virtual string GenusName => "Monopenchelys";

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
