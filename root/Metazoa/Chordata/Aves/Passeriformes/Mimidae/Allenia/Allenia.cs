using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Allenia;

/// <summary>
/// Abstract class for Allenia (genus).
/// NCBI TaxId: 2820826
/// </summary>
public abstract class Allenia : Mimidae, IAllenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2820826;

    /// <inheritdoc />
    public virtual string GenusName => "Allenia";

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
