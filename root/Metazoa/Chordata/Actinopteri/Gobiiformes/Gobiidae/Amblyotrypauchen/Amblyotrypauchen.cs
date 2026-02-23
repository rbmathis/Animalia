using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblyotrypauchen;

/// <summary>
/// Abstract class for Amblyotrypauchen (genus).
/// NCBI TaxId: 1979810
/// </summary>
public abstract class Amblyotrypauchen : Gobiidae, IAmblyotrypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyotrypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1979810;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyotrypauchen";

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
