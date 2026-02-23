using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pseudodistomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pseudodistomidae.Pseudodistoma;

/// <summary>
/// Abstract class for Pseudodistoma (genus).
/// NCBI TaxId: 282280
/// </summary>
public abstract class Pseudodistoma : Pseudodistomidae, IPseudodistoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudodistoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 282280;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudodistoma";

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
