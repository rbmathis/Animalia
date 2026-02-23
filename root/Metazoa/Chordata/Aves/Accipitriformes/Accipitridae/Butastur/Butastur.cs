using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Butastur;

/// <summary>
/// Abstract class for Butastur (genus).
/// NCBI TaxId: 335206
/// </summary>
public abstract class Butastur : Accipitridae, IButastur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Butastur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335206;

    /// <inheritdoc />
    public virtual string GenusName => "Butastur";

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
