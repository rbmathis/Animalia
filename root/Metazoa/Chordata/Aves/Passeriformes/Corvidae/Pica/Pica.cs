using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Pica;

/// <summary>
/// Abstract class for Pica (genus).
/// NCBI TaxId: 34923
/// </summary>
public abstract class Pica : Corvidae, IPica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34923;

    /// <inheritdoc />
    public virtual string GenusName => "Pica";

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
