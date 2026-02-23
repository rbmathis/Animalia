using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Stipecampus;

/// <summary>
/// Abstract class for Stipecampus (genus).
/// NCBI TaxId: 1914740
/// </summary>
public abstract class Stipecampus : Syngnathidae, IStipecampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stipecampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914740;

    /// <inheritdoc />
    public virtual string GenusName => "Stipecampus";

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
