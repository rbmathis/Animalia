using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Peter;

/// <summary>
/// Abstract class for Peter (genus).
/// NCBI TaxId: 3363462
/// </summary>
public abstract class Peter : Gobiidae, IPeter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363462;

    /// <inheritdoc />
    public virtual string GenusName => "Peter";

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
