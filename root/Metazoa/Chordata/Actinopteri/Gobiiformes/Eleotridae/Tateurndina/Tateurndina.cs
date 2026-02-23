using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Tateurndina;

/// <summary>
/// Abstract class for Tateurndina (genus).
/// NCBI TaxId: 86217
/// </summary>
public abstract class Tateurndina : Eleotridae, ITateurndina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tateurndina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86217;

    /// <inheritdoc />
    public virtual string GenusName => "Tateurndina";

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
