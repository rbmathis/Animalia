using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Histurgops;

/// <summary>
/// Abstract class for Histurgops (genus).
/// NCBI TaxId: 2557990
/// </summary>
public abstract class Histurgops : Ploceidae, IHisturgops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histurgops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2557990;

    /// <inheritdoc />
    public virtual string GenusName => "Histurgops";

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
