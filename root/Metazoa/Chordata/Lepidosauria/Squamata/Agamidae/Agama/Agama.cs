using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

/// <summary>
/// Abstract class for Agama (genus).
/// NCBI TaxId: 52207
/// </summary>
public abstract class Agama : Agamidae, IAgama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52207;

    /// <inheritdoc />
    public virtual string GenusName => "Agama";

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
