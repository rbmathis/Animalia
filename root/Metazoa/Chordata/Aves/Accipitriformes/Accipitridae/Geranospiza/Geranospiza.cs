using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Geranospiza;

/// <summary>
/// Abstract class for Geranospiza (genus).
/// NCBI TaxId: 321127
/// </summary>
public abstract class Geranospiza : Accipitridae, IGeranospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geranospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321127;

    /// <inheritdoc />
    public virtual string GenusName => "Geranospiza";

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
