using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenotrypauchen;

/// <summary>
/// Abstract class for Ctenotrypauchen (genus).
/// NCBI TaxId: 1765092
/// </summary>
public abstract class Ctenotrypauchen : Gobiidae, ICtenotrypauchen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenotrypauchen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1765092;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenotrypauchen";

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
