using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Priolepis;

/// <summary>
/// Abstract class for Priolepis (genus).
/// NCBI TaxId: 166756
/// </summary>
public abstract class Priolepis : Gobiidae, IPriolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166756;

    /// <inheritdoc />
    public virtual string GenusName => "Priolepis";

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
