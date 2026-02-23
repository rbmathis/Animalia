using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Pseudogramma;

/// <summary>
/// Abstract class for Pseudogramma (genus).
/// NCBI TaxId: 274730
/// </summary>
public abstract class Pseudogramma : Serranidae, IPseudogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274730;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudogramma";

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
