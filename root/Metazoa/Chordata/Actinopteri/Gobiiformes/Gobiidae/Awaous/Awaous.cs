using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Awaous;

/// <summary>
/// Abstract class for Awaous (genus).
/// NCBI TaxId: 70083
/// </summary>
public abstract class Awaous : Gobiidae, IAwaous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Awaous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70083;

    /// <inheritdoc />
    public virtual string GenusName => "Awaous";

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
