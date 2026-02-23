using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Nettastoma;

/// <summary>
/// Abstract class for Nettastoma (genus).
/// NCBI TaxId: 118176
/// </summary>
public abstract class Nettastoma : Nettastomatidae, INettastoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nettastoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118176;

    /// <inheritdoc />
    public virtual string GenusName => "Nettastoma";

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
