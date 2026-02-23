using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Erithacus;

/// <summary>
/// Abstract class for Erithacus (genus).
/// NCBI TaxId: 36283
/// </summary>
public abstract class Erithacus : Turdidae, IErithacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erithacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36283;

    /// <inheritdoc />
    public virtual string GenusName => "Erithacus";

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
