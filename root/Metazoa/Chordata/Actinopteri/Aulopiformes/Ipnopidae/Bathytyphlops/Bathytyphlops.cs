using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathytyphlops;

/// <summary>
/// Abstract class for Bathytyphlops (genus).
/// NCBI TaxId: 1263182
/// </summary>
public abstract class Bathytyphlops : Ipnopidae, IBathytyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathytyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1263182;

    /// <inheritdoc />
    public virtual string GenusName => "Bathytyphlops";

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
