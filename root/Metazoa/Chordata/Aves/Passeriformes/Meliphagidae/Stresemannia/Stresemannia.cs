using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Stresemannia;

/// <summary>
/// Abstract class for Stresemannia (genus).
/// NCBI TaxId: 1439390
/// </summary>
public abstract class Stresemannia : Meliphagidae, IStresemannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stresemannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1439390;

    /// <inheritdoc />
    public virtual string GenusName => "Stresemannia";

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
