using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Periporphyrus;

/// <summary>
/// Abstract class for Periporphyrus (genus).
/// NCBI TaxId: 460182
/// </summary>
public abstract class Periporphyrus : Cardinalidae, IPeriporphyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Periporphyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460182;

    /// <inheritdoc />
    public virtual string GenusName => "Periporphyrus";

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
