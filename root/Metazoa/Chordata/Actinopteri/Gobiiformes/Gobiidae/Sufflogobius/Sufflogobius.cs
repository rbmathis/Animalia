using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sufflogobius;

/// <summary>
/// Abstract class for Sufflogobius (genus).
/// NCBI TaxId: 1108805
/// </summary>
public abstract class Sufflogobius : Gobiidae, ISufflogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sufflogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108805;

    /// <inheritdoc />
    public virtual string GenusName => "Sufflogobius";

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
