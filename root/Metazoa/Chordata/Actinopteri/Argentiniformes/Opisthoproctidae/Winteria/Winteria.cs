using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Winteria;

/// <summary>
/// Abstract class for Winteria (genus).
/// NCBI TaxId: 2578413
/// </summary>
public abstract class Winteria : Opisthoproctidae, IWinteria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Winteria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578413;

    /// <inheritdoc />
    public virtual string GenusName => "Winteria";

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
