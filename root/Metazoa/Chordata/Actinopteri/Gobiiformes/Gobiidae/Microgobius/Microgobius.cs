using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Microgobius;

/// <summary>
/// Abstract class for Microgobius (genus).
/// NCBI TaxId: 203319
/// </summary>
public abstract class Microgobius : Gobiidae, IMicrogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microgobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203319;

    /// <inheritdoc />
    public virtual string GenusName => "Microgobius";

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
