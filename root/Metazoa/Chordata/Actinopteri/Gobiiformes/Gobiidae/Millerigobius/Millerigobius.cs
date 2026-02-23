using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Millerigobius;

/// <summary>
/// Abstract class for Millerigobius (genus).
/// NCBI TaxId: 1079949
/// </summary>
public abstract class Millerigobius : Gobiidae, IMillerigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Millerigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1079949;

    /// <inheritdoc />
    public virtual string GenusName => "Millerigobius";

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
