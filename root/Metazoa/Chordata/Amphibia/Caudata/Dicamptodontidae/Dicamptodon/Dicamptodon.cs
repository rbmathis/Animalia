using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Dicamptodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Dicamptodontidae.Dicamptodon;

/// <summary>
/// Abstract class for Dicamptodon (genus).
/// NCBI TaxId: 43476
/// </summary>
public abstract class Dicamptodon : Dicamptodontidae, IDicamptodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicamptodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43476;

    /// <inheritdoc />
    public virtual string GenusName => "Dicamptodon";

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
