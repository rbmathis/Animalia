using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Tregellasia;

/// <summary>
/// Abstract class for Tregellasia (genus).
/// NCBI TaxId: 175138
/// </summary>
public abstract class Tregellasia : Petroicidae, ITregellasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tregellasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175138;

    /// <inheritdoc />
    public virtual string GenusName => "Tregellasia";

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
