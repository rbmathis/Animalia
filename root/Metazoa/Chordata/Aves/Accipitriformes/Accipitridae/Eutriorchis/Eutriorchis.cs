using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Eutriorchis;

/// <summary>
/// Abstract class for Eutriorchis (genus).
/// NCBI TaxId: 321075
/// </summary>
public abstract class Eutriorchis : Accipitridae, IEutriorchis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutriorchis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321075;

    /// <inheritdoc />
    public virtual string GenusName => "Eutriorchis";

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
