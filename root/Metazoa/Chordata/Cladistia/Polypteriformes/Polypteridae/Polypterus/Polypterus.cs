using AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Polypterus;

/// <summary>
/// Abstract class for Polypterus (genus).
/// NCBI TaxId: 8290
/// </summary>
public abstract class Polypterus : Polypteridae, IPolypterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polypterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8290;

    /// <inheritdoc />
    public virtual string GenusName => "Polypterus";

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
