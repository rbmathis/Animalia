using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polyclinidae.Synoicum;

/// <summary>
/// Abstract class for Synoicum (genus).
/// NCBI TaxId: 562744
/// </summary>
public abstract class Synoicum : Polyclinidae, ISynoicum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synoicum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 562744;

    /// <inheritdoc />
    public virtual string GenusName => "Synoicum";

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
