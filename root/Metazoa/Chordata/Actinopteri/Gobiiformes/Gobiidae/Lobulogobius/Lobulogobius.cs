using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lobulogobius;

/// <summary>
/// Abstract class for Lobulogobius (genus).
/// NCBI TaxId: 2797499
/// </summary>
public abstract class Lobulogobius : Gobiidae, ILobulogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lobulogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2797499;

    /// <inheritdoc />
    public virtual string GenusName => "Lobulogobius";

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
