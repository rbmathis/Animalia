using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Scopelogadus;

/// <summary>
/// Abstract class for Scopelogadus (genus).
/// NCBI TaxId: 114874
/// </summary>
public abstract class Scopelogadus : Melamphaidae, IScopelogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopelogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114874;

    /// <inheritdoc />
    public virtual string GenusName => "Scopelogadus";

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
