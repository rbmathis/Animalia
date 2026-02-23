using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Nannocharax;

/// <summary>
/// Abstract class for Nannocharax (genus).
/// NCBI TaxId: 304067
/// </summary>
public abstract class Nannocharax : Distichodontidae, INannocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304067;

    /// <inheritdoc />
    public virtual string GenusName => "Nannocharax";

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
