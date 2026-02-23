using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pachyramphus;

/// <summary>
/// Abstract class for Pachyramphus (genus).
/// NCBI TaxId: 114332
/// </summary>
public abstract class Pachyramphus : Tyrannidae, IPachyramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114332;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyramphus";

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
