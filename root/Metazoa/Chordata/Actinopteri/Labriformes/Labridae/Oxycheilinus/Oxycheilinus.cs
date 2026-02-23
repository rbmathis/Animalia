using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Oxycheilinus;

/// <summary>
/// Abstract class for Oxycheilinus (genus).
/// NCBI TaxId: 241326
/// </summary>
public abstract class Oxycheilinus : Labridae, IOxycheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxycheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241326;

    /// <inheritdoc />
    public virtual string GenusName => "Oxycheilinus";

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
