using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Sarada;

/// <summary>
/// Abstract class for Sarada (genus).
/// NCBI TaxId: 1819755
/// </summary>
public abstract class Sarada : Agamidae, ISarada
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarada";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1819755;

    /// <inheritdoc />
    public virtual string GenusName => "Sarada";

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
