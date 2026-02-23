using AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Corythaeola;

/// <summary>
/// Abstract class for Corythaeola (genus).
/// NCBI TaxId: 103953
/// </summary>
public abstract class Corythaeola : Musophagidae, ICorythaeola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corythaeola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103953;

    /// <inheritdoc />
    public virtual string GenusName => "Corythaeola";

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
