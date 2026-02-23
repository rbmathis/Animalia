using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Mino;

/// <summary>
/// Abstract class for Mino (genus).
/// NCBI TaxId: 245039
/// </summary>
public abstract class Mino : Sturnidae, IMino
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mino";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245039;

    /// <inheritdoc />
    public virtual string GenusName => "Mino";

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
