using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Heliothryx;

/// <summary>
/// Abstract class for Heliothryx (genus).
/// NCBI TaxId: 190687
/// </summary>
public abstract class Heliothryx : Trochilidae, IHeliothryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliothryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190687;

    /// <inheritdoc />
    public virtual string GenusName => "Heliothryx";

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
