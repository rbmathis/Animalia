using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Gobiomorus;

/// <summary>
/// Abstract class for Gobiomorus (genus).
/// NCBI TaxId: 308071
/// </summary>
public abstract class Gobiomorus : Eleotridae, IGobiomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308071;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiomorus";

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
