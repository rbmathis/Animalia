using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Poecilodryas;

/// <summary>
/// Abstract class for Poecilodryas (genus).
/// NCBI TaxId: 665155
/// </summary>
public abstract class Poecilodryas : Petroicidae, IPoecilodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poecilodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 665155;

    /// <inheritdoc />
    public virtual string GenusName => "Poecilodryas";

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
