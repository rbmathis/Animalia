using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Tachyspiza;

/// <summary>
/// Abstract class for Tachyspiza (genus).
/// NCBI TaxId: 3410255
/// </summary>
public abstract class Tachyspiza : Accipitridae, ITachyspiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachyspiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3410255;

    /// <inheritdoc />
    public virtual string GenusName => "Tachyspiza";

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
