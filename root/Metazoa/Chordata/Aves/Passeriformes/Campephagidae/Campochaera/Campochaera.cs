using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Campochaera;

/// <summary>
/// Abstract class for Campochaera (genus).
/// NCBI TaxId: 498411
/// </summary>
public abstract class Campochaera : Campephagidae, ICampochaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campochaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 498411;

    /// <inheritdoc />
    public virtual string GenusName => "Campochaera";

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
