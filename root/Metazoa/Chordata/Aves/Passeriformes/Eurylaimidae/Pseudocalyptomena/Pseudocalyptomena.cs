using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Pseudocalyptomena;

/// <summary>
/// Abstract class for Pseudocalyptomena (genus).
/// NCBI TaxId: 363778
/// </summary>
public abstract class Pseudocalyptomena : Eurylaimidae, IPseudocalyptomena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocalyptomena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 363778;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocalyptomena";

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
