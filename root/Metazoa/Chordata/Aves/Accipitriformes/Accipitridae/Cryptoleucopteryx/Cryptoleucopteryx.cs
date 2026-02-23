using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Cryptoleucopteryx;

/// <summary>
/// Abstract class for Cryptoleucopteryx (genus).
/// NCBI TaxId: 2869516
/// </summary>
public abstract class Cryptoleucopteryx : Accipitridae, ICryptoleucopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptoleucopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2869516;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptoleucopteryx";

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
