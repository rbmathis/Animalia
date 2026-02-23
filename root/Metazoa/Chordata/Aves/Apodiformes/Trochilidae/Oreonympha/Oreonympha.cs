using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Oreonympha;

/// <summary>
/// Abstract class for Oreonympha (genus).
/// NCBI TaxId: 56660
/// </summary>
public abstract class Oreonympha : Trochilidae, IOreonympha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreonympha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56660;

    /// <inheritdoc />
    public virtual string GenusName => "Oreonympha";

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
