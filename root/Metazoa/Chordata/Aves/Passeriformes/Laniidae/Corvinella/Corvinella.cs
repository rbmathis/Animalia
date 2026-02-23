using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Corvinella;

/// <summary>
/// Abstract class for Corvinella (genus).
/// NCBI TaxId: 187424
/// </summary>
public abstract class Corvinella : Laniidae, ICorvinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corvinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187424;

    /// <inheritdoc />
    public virtual string GenusName => "Corvinella";

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
