using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Anthochaera;

/// <summary>
/// Abstract class for Anthochaera (genus).
/// NCBI TaxId: 266337
/// </summary>
public abstract class Anthochaera : Meliphagidae, IAnthochaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthochaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266337;

    /// <inheritdoc />
    public virtual string GenusName => "Anthochaera";

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
