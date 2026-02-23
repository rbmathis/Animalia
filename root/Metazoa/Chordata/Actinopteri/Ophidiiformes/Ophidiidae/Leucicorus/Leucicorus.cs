using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Leucicorus;

/// <summary>
/// Abstract class for Leucicorus (genus).
/// NCBI TaxId: 1843793
/// </summary>
public abstract class Leucicorus : Ophidiidae, ILeucicorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucicorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843793;

    /// <inheritdoc />
    public virtual string GenusName => "Leucicorus";

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
