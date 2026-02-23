using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Mogurnda;

/// <summary>
/// Abstract class for Mogurnda (genus).
/// NCBI TaxId: 78194
/// </summary>
public abstract class Mogurnda : Eleotridae, IMogurnda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mogurnda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78194;

    /// <inheritdoc />
    public virtual string GenusName => "Mogurnda";

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
