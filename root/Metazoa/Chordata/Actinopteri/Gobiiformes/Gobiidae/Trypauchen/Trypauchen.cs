using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchen;

/// <summary>
/// Abstract class for Trypauchen (genus).
/// NCBI TaxId: 910305
/// </summary>
public abstract class Trypauchen : Gobiidae, ITrypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 910305;

    /// <inheritdoc />
    public virtual string GenusName => "Trypauchen";

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
