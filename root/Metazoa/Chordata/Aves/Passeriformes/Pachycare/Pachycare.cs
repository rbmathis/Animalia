using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycare;

/// <summary>
/// Abstract class for Pachycare (genus).
/// NCBI TaxId: 692110
/// </summary>
public abstract class Pachycare : Passeriformes, IPachycare
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachycare";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 692110;

    /// <inheritdoc />
    public virtual string GenusName => "Pachycare";

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
