using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Stilpnia;

/// <summary>
/// Abstract class for Stilpnia (genus).
/// NCBI TaxId: 2986137
/// </summary>
public abstract class Stilpnia : Thraupidae, IStilpnia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stilpnia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986137;

    /// <inheritdoc />
    public virtual string GenusName => "Stilpnia";

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
