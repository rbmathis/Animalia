using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lythrypnus;

/// <summary>
/// Abstract class for Lythrypnus (genus).
/// NCBI TaxId: 185749
/// </summary>
public abstract class Lythrypnus : Gobiidae, ILythrypnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lythrypnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185749;

    /// <inheritdoc />
    public virtual string GenusName => "Lythrypnus";

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
