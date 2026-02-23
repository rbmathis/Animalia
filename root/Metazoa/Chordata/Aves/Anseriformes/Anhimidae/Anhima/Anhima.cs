using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anhimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anhimidae.Anhima;

/// <summary>
/// Abstract class for Anhima (genus).
/// NCBI TaxId: 56279
/// </summary>
public abstract class Anhima : Anhimidae, IAnhima
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anhima";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56279;

    /// <inheritdoc />
    public virtual string GenusName => "Anhima";

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
