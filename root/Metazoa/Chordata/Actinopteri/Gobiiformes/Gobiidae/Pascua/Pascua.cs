using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pascua;

/// <summary>
/// Abstract class for Pascua (genus).
/// NCBI TaxId: 3363461
/// </summary>
public abstract class Pascua : Gobiidae, IPascua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pascua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363461;

    /// <inheritdoc />
    public virtual string GenusName => "Pascua";

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
