using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Scleroptila;

/// <summary>
/// Abstract class for Scleroptila (genus).
/// NCBI TaxId: 388993
/// </summary>
public abstract class Scleroptila : Phasianidae, IScleroptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scleroptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388993;

    /// <inheritdoc />
    public virtual string GenusName => "Scleroptila";

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
