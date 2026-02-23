using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Malacoptila;

/// <summary>
/// Abstract class for Malacoptila (genus).
/// NCBI TaxId: 488311
/// </summary>
public abstract class Malacoptila : Bucconidae, IMalacoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 488311;

    /// <inheritdoc />
    public virtual string GenusName => "Malacoptila";

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
