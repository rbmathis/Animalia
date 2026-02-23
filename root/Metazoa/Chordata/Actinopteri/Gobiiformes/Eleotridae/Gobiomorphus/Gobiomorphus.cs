using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Gobiomorphus;

/// <summary>
/// Abstract class for Gobiomorphus (genus).
/// NCBI TaxId: 86236
/// </summary>
public abstract class Gobiomorphus : Eleotridae, IGobiomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86236;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiomorphus";

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
