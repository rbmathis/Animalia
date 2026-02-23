using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Speculanas;

/// <summary>
/// Abstract class for Speculanas (genus).
/// NCBI TaxId: 75878
/// </summary>
public abstract class Speculanas : Anatidae, ISpeculanas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speculanas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75878;

    /// <inheritdoc />
    public virtual string GenusName => "Speculanas";

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
