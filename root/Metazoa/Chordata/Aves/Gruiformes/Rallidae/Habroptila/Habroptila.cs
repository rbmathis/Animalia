using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Habroptila;

/// <summary>
/// Abstract class for Habroptila (genus).
/// NCBI TaxId: 1150655
/// </summary>
public abstract class Habroptila : Rallidae, IHabroptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Habroptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150655;

    /// <inheritdoc />
    public virtual string GenusName => "Habroptila";

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
