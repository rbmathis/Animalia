using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Gampsonyx;

/// <summary>
/// Abstract class for Gampsonyx (genus).
/// NCBI TaxId: 56284
/// </summary>
public abstract class Gampsonyx : Accipitridae, IGampsonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gampsonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56284;

    /// <inheritdoc />
    public virtual string GenusName => "Gampsonyx";

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
