using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Synoicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Synoicidae.Amaroucium;

/// <summary>
/// Abstract class for Amaroucium (genus).
/// NCBI TaxId: 107397
/// </summary>
public abstract class Amaroucium : Synoicidae, IAmaroucium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amaroucium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107397;

    /// <inheritdoc />
    public virtual string GenusName => "Amaroucium";

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
