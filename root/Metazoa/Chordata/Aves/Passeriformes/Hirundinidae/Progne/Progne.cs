using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Progne;

/// <summary>
/// Abstract class for Progne (genus).
/// NCBI TaxId: 72874
/// </summary>
public abstract class Progne : Hirundinidae, IProgne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Progne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72874;

    /// <inheritdoc />
    public virtual string GenusName => "Progne";

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
