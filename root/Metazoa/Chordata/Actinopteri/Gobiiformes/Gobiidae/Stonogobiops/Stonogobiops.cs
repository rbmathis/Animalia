using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Stonogobiops;

/// <summary>
/// Abstract class for Stonogobiops (genus).
/// NCBI TaxId: 622433
/// </summary>
public abstract class Stonogobiops : Gobiidae, IStonogobiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stonogobiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 622433;

    /// <inheritdoc />
    public virtual string GenusName => "Stonogobiops";

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
