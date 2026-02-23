using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Eleginus;

/// <summary>
/// Abstract class for Eleginus (genus).
/// NCBI TaxId: 8046
/// </summary>
public abstract class Eleginus : Gadidae, IEleginus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleginus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8046;

    /// <inheritdoc />
    public virtual string GenusName => "Eleginus";

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
