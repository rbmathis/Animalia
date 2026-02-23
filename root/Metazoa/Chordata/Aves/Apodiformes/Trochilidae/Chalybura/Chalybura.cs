using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chalybura;

/// <summary>
/// Abstract class for Chalybura (genus).
/// NCBI TaxId: 472791
/// </summary>
public abstract class Chalybura : Trochilidae, IChalybura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalybura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472791;

    /// <inheritdoc />
    public virtual string GenusName => "Chalybura";

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
