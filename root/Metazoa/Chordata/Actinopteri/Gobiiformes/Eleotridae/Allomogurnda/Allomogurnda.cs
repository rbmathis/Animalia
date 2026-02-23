using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Allomogurnda;

/// <summary>
/// Abstract class for Allomogurnda (genus).
/// NCBI TaxId: 2888840
/// </summary>
public abstract class Allomogurnda : Eleotridae, IAllomogurnda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allomogurnda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2888840;

    /// <inheritdoc />
    public virtual string GenusName => "Allomogurnda";

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
