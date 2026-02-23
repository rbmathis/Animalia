using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mohoidae.Chaetoptila;

/// <summary>
/// Abstract class for Chaetoptila (genus).
/// NCBI TaxId: 572103
/// </summary>
public abstract class Chaetoptila : Mohoidae, IChaetoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 572103;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetoptila";

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
