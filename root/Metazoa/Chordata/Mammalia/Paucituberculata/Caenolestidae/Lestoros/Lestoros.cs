using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Lestoros;

/// <summary>
/// Abstract class for Lestoros (genus).
/// NCBI TaxId: 42730
/// </summary>
public abstract class Lestoros : Caenolestidae, ILestoros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lestoros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42730;

    /// <inheritdoc />
    public virtual string GenusName => "Lestoros";

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
