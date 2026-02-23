using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Alloclinus;

/// <summary>
/// Abstract class for Alloclinus (genus).
/// NCBI TaxId: 314244
/// </summary>
public abstract class Alloclinus : Labrisomidae, IAlloclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alloclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 314244;

    /// <inheritdoc />
    public virtual string GenusName => "Alloclinus";

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
