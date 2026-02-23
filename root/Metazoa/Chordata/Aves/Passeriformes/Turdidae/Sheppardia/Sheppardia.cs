using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Sheppardia;

/// <summary>
/// Abstract class for Sheppardia (genus).
/// NCBI TaxId: 74354
/// </summary>
public abstract class Sheppardia : Turdidae, ISheppardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sheppardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74354;

    /// <inheritdoc />
    public virtual string GenusName => "Sheppardia";

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
