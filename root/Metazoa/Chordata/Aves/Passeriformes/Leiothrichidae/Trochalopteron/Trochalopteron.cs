using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Trochalopteron;

/// <summary>
/// Abstract class for Trochalopteron (genus).
/// NCBI TaxId: 1673679
/// </summary>
public abstract class Trochalopteron : Leiothrichidae, ITrochalopteron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trochalopteron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1673679;

    /// <inheritdoc />
    public virtual string GenusName => "Trochalopteron";

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
