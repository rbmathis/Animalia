using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Chaeturichthys;

/// <summary>
/// Abstract class for Chaeturichthys (genus).
/// NCBI TaxId: 1124595
/// </summary>
public abstract class Chaeturichthys : Gobiidae, IChaeturichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaeturichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1124595;

    /// <inheritdoc />
    public virtual string GenusName => "Chaeturichthys";

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
