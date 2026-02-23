using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parachaeturichthys;

/// <summary>
/// Abstract class for Parachaeturichthys (genus).
/// NCBI TaxId: 376885
/// </summary>
public abstract class Parachaeturichthys : Gobiidae, IParachaeturichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachaeturichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376885;

    /// <inheritdoc />
    public virtual string GenusName => "Parachaeturichthys";

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
