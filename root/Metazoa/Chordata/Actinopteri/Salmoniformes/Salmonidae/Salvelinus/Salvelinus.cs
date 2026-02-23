using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salvelinus;

/// <summary>
/// Abstract class for Salvelinus (genus).
/// NCBI TaxId: 8033
/// </summary>
public abstract class Salvelinus : Salmonidae, ISalvelinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salvelinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8033;

    /// <inheritdoc />
    public virtual string GenusName => "Salvelinus";

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
