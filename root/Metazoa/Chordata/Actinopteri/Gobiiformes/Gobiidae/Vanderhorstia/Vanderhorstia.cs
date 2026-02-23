using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Vanderhorstia;

/// <summary>
/// Abstract class for Vanderhorstia (genus).
/// NCBI TaxId: 579952
/// </summary>
public abstract class Vanderhorstia : Gobiidae, IVanderhorstia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vanderhorstia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 579952;

    /// <inheritdoc />
    public virtual string GenusName => "Vanderhorstia";

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
