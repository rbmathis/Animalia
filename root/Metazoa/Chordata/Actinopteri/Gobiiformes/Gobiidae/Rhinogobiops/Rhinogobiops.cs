using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Rhinogobiops;

/// <summary>
/// Abstract class for Rhinogobiops (genus).
/// NCBI TaxId: 151722
/// </summary>
public abstract class Rhinogobiops : Gobiidae, IRhinogobiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinogobiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 151722;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinogobiops";

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
