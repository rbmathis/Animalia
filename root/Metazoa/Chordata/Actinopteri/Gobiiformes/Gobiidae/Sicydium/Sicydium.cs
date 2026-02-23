using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicydium;

/// <summary>
/// Abstract class for Sicydium (genus).
/// NCBI TaxId: 637726
/// </summary>
public abstract class Sicydium : Gobiidae, ISicydium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sicydium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 637726;

    /// <inheritdoc />
    public virtual string GenusName => "Sicydium";

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
