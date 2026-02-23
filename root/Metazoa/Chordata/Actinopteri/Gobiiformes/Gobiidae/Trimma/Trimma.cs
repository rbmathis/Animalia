using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trimma;

/// <summary>
/// Abstract class for Trimma (genus).
/// NCBI TaxId: 498270
/// </summary>
public abstract class Trimma : Gobiidae, ITrimma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trimma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 498270;

    /// <inheritdoc />
    public virtual string GenusName => "Trimma";

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
