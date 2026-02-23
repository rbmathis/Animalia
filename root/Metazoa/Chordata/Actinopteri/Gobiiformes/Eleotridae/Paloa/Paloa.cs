using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Paloa;

/// <summary>
/// Abstract class for Paloa (genus).
/// NCBI TaxId: 3363449
/// </summary>
public abstract class Paloa : Eleotridae, IPaloa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paloa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363449;

    /// <inheritdoc />
    public virtual string GenusName => "Paloa";

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
