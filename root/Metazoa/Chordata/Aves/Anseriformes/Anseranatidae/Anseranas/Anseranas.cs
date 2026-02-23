using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anseranatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anseranatidae.Anseranas;

/// <summary>
/// Abstract class for Anseranas (genus).
/// NCBI TaxId: 8850
/// </summary>
public abstract class Anseranas : Anseranatidae, IAnseranas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anseranas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8850;

    /// <inheritdoc />
    public virtual string GenusName => "Anseranas";

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
