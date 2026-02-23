using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Vespertilio;

/// <summary>
/// Abstract class for Vespertilio (genus).
/// NCBI TaxId: 59484
/// </summary>
public abstract class Vespertilio : Vespertilionidae, IVespertilio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vespertilio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59484;

    /// <inheritdoc />
    public virtual string GenusName => "Vespertilio";

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
