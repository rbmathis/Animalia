using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Anthornis;

/// <summary>
/// Abstract class for Anthornis (genus).
/// NCBI TaxId: 698974
/// </summary>
public abstract class Anthornis : Meliphagidae, IAnthornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 698974;

    /// <inheritdoc />
    public virtual string GenusName => "Anthornis";

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
