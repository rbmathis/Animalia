using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Thylogale;

/// <summary>
/// Abstract class for Thylogale (genus).
/// NCBI TaxId: 9326
/// </summary>
public abstract class Thylogale : Macropodidae, IThylogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thylogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9326;

    /// <inheritdoc />
    public virtual string GenusName => "Thylogale";

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
