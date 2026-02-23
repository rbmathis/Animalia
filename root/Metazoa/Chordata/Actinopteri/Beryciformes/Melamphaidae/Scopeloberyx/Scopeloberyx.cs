using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Scopeloberyx;

/// <summary>
/// Abstract class for Scopeloberyx (genus).
/// NCBI TaxId: 94933
/// </summary>
public abstract class Scopeloberyx : Melamphaidae, IScopeloberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopeloberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94933;

    /// <inheritdoc />
    public virtual string GenusName => "Scopeloberyx";

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
