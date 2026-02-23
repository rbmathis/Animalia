using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gymnesigobius;

/// <summary>
/// Abstract class for Gymnesigobius (genus).
/// NCBI TaxId: 2602787
/// </summary>
public abstract class Gymnesigobius : Gobiidae, IGymnesigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnesigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602787;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnesigobius";

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
