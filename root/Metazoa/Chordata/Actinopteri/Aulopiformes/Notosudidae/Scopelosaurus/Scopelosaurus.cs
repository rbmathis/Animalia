using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae.Scopelosaurus;

/// <summary>
/// Abstract class for Scopelosaurus (genus).
/// NCBI TaxId: 172127
/// </summary>
public abstract class Scopelosaurus : Notosudidae, IScopelosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopelosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172127;

    /// <inheritdoc />
    public virtual string GenusName => "Scopelosaurus";

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
