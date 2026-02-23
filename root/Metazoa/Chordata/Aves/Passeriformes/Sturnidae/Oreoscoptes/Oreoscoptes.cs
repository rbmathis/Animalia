using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Oreoscoptes;

/// <summary>
/// Abstract class for Oreoscoptes (genus).
/// NCBI TaxId: 99872
/// </summary>
public abstract class Oreoscoptes : Sturnidae, IOreoscoptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreoscoptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 99872;

    /// <inheritdoc />
    public virtual string GenusName => "Oreoscoptes";

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
