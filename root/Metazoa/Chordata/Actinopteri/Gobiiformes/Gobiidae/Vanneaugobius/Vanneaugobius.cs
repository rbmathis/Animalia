using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Vanneaugobius;

/// <summary>
/// Abstract class for Vanneaugobius (genus).
/// NCBI TaxId: 203338
/// </summary>
public abstract class Vanneaugobius : Gobiidae, IVanneaugobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vanneaugobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203338;

    /// <inheritdoc />
    public virtual string GenusName => "Vanneaugobius";

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
