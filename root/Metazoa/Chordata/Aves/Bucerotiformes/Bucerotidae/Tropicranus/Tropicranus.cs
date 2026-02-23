using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Tropicranus;

/// <summary>
/// Abstract class for Tropicranus (genus).
/// NCBI TaxId: 866442
/// </summary>
public abstract class Tropicranus : Bucerotidae, ITropicranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropicranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 866442;

    /// <inheritdoc />
    public virtual string GenusName => "Tropicranus";

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
