using AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

/// <summary>
/// Abstract class for Sternotherus (genus).
/// NCBI TaxId: 37592
/// </summary>
public abstract class Sternotherus : Kinosternidae, ISternotherus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternotherus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37592;

    /// <inheritdoc />
    public virtual string GenusName => "Sternotherus";

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
