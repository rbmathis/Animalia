using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Oxyruncus;

/// <summary>
/// Abstract class for Oxyruncus (genus).
/// NCBI TaxId: 114330
/// </summary>
public abstract class Oxyruncus : Cotingidae, IOxyruncus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyruncus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114330;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyruncus";

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
