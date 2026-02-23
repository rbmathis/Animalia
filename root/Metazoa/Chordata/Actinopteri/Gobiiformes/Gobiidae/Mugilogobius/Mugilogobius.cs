using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mugilogobius;

/// <summary>
/// Abstract class for Mugilogobius (genus).
/// NCBI TaxId: 88199
/// </summary>
public abstract class Mugilogobius : Gobiidae, IMugilogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mugilogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88199;

    /// <inheritdoc />
    public virtual string GenusName => "Mugilogobius";

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
