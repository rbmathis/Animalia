using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Butis;

/// <summary>
/// Abstract class for Butis (genus).
/// NCBI TaxId: 86225
/// </summary>
public abstract class Butis : Eleotridae, IButis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Butis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86225;

    /// <inheritdoc />
    public virtual string GenusName => "Butis";

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
