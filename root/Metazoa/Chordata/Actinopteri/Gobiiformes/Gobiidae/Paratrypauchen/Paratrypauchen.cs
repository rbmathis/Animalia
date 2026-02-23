using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paratrypauchen;

/// <summary>
/// Abstract class for Paratrypauchen (genus).
/// NCBI TaxId: 1054629
/// </summary>
public abstract class Paratrypauchen : Gobiidae, IParatrypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratrypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1054629;

    /// <inheritdoc />
    public virtual string GenusName => "Paratrypauchen";

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
