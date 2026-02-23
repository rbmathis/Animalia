using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Lipaugus;

/// <summary>
/// Abstract class for Lipaugus (genus).
/// NCBI TaxId: 114310
/// </summary>
public abstract class Lipaugus : Cotingidae, ILipaugus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipaugus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114310;

    /// <inheritdoc />
    public virtual string GenusName => "Lipaugus";

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
