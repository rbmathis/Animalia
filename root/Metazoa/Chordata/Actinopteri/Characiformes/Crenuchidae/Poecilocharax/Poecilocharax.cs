using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Poecilocharax;

/// <summary>
/// Abstract class for Poecilocharax (genus).
/// NCBI TaxId: 930376
/// </summary>
public abstract class Poecilocharax : Crenuchidae, IPoecilocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poecilocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930376;

    /// <inheritdoc />
    public virtual string GenusName => "Poecilocharax";

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
