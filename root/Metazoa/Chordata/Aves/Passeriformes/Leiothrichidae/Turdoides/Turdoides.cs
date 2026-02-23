using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Turdoides;

/// <summary>
/// Abstract class for Turdoides (genus).
/// NCBI TaxId: 147061
/// </summary>
public abstract class Turdoides : Leiothrichidae, ITurdoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Turdoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147061;

    /// <inheritdoc />
    public virtual string GenusName => "Turdoides";

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
