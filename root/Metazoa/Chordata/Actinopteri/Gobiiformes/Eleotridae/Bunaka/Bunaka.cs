using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Bunaka;

/// <summary>
/// Abstract class for Bunaka (genus).
/// NCBI TaxId: 641935
/// </summary>
public abstract class Bunaka : Eleotridae, IBunaka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bunaka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641935;

    /// <inheritdoc />
    public virtual string GenusName => "Bunaka";

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
