using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Delichon;

/// <summary>
/// Abstract class for Delichon (genus).
/// NCBI TaxId: 88115
/// </summary>
public abstract class Delichon : Hirundinidae, IDelichon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delichon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88115;

    /// <inheritdoc />
    public virtual string GenusName => "Delichon";

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
