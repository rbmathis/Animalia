using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Paradiplospinus;

/// <summary>
/// Abstract class for Paradiplospinus (genus).
/// NCBI TaxId: 399146
/// </summary>
public abstract class Paradiplospinus : Gempylidae, IParadiplospinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradiplospinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399146;

    /// <inheritdoc />
    public virtual string GenusName => "Paradiplospinus";

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
