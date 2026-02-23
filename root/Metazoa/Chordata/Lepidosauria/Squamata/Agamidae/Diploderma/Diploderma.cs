using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Diploderma;

/// <summary>
/// Abstract class for Diploderma (genus).
/// NCBI TaxId: 2546160
/// </summary>
public abstract class Diploderma : Agamidae, IDiploderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diploderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546160;

    /// <inheritdoc />
    public virtual string GenusName => "Diploderma";

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
