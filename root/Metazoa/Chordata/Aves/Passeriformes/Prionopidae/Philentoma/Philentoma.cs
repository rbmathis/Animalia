using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Prionopidae.Philentoma;

/// <summary>
/// Abstract class for Philentoma (genus).
/// NCBI TaxId: 316103
/// </summary>
public abstract class Philentoma : Prionopidae, IPhilentoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philentoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316103;

    /// <inheritdoc />
    public virtual string GenusName => "Philentoma";

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
