using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Myzomela;

/// <summary>
/// Abstract class for Myzomela (genus).
/// NCBI TaxId: 108837
/// </summary>
public abstract class Myzomela : Meliphagidae, IMyzomela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myzomela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108837;

    /// <inheritdoc />
    public virtual string GenusName => "Myzomela";

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
