using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Guavina;

/// <summary>
/// Abstract class for Guavina (genus).
/// NCBI TaxId: 308098
/// </summary>
public abstract class Guavina : Eleotridae, IGuavina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guavina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308098;

    /// <inheritdoc />
    public virtual string GenusName => "Guavina";

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
