using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Parviparma;

/// <summary>
/// Abstract class for Parviparma (genus).
/// NCBI TaxId: 3040451
/// </summary>
public abstract class Parviparma : Eleotridae, IParviparma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parviparma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040451;

    /// <inheritdoc />
    public virtual string GenusName => "Parviparma";

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
