using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Bathymicrops;

/// <summary>
/// Abstract class for Bathymicrops (genus).
/// NCBI TaxId: 1414491
/// </summary>
public abstract class Bathymicrops : Ipnopidae, IBathymicrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathymicrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1414491;

    /// <inheritdoc />
    public virtual string GenusName => "Bathymicrops";

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
