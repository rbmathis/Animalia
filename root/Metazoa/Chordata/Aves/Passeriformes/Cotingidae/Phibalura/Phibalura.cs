using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Phibalura;

/// <summary>
/// Abstract class for Phibalura (genus).
/// NCBI TaxId: 1506490
/// </summary>
public abstract class Phibalura : Cotingidae, IPhibalura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phibalura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1506490;

    /// <inheritdoc />
    public virtual string GenusName => "Phibalura";

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
