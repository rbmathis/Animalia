using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Amarsipidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Amarsipidae.Amarsipus;

/// <summary>
/// Abstract class for Amarsipus (genus).
/// NCBI TaxId: 2042711
/// </summary>
public abstract class Amarsipus : Amarsipidae, IAmarsipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amarsipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2042711;

    /// <inheritdoc />
    public virtual string GenusName => "Amarsipus";

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
