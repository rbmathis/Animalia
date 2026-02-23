using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Phylidonyris;

/// <summary>
/// Abstract class for Phylidonyris (genus).
/// NCBI TaxId: 266414
/// </summary>
public abstract class Phylidonyris : Meliphagidae, IPhylidonyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phylidonyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266414;

    /// <inheritdoc />
    public virtual string GenusName => "Phylidonyris";

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
