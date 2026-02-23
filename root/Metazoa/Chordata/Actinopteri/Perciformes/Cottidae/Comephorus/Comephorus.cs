using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Comephorus;

/// <summary>
/// Abstract class for Comephorus (genus).
/// NCBI TaxId: 61640
/// </summary>
public abstract class Comephorus : Cottidae, IComephorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Comephorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61640;

    /// <inheritdoc />
    public virtual string GenusName => "Comephorus";

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
