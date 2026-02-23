using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Ratsirakia;

/// <summary>
/// Abstract class for Ratsirakia (genus).
/// NCBI TaxId: 308087
/// </summary>
public abstract class Ratsirakia : Eleotridae, IRatsirakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ratsirakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308087;

    /// <inheritdoc />
    public virtual string GenusName => "Ratsirakia";

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
