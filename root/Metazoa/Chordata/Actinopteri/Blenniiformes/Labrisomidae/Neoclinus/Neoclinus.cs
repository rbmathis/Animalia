using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Neoclinus;

/// <summary>
/// Abstract class for Neoclinus (genus).
/// NCBI TaxId: 57829
/// </summary>
public abstract class Neoclinus : Labrisomidae, INeoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57829;

    /// <inheritdoc />
    public virtual string GenusName => "Neoclinus";

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
