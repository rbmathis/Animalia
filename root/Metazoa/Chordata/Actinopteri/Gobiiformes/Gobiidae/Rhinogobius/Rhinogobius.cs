using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Rhinogobius;

/// <summary>
/// Abstract class for Rhinogobius (genus).
/// NCBI TaxId: 63457
/// </summary>
public abstract class Rhinogobius : Gobiidae, IRhinogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63457;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinogobius";

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
