using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Laliostoma;

/// <summary>
/// Abstract class for Laliostoma (genus).
/// NCBI TaxId: 129010
/// </summary>
public abstract class Laliostoma : Mantellidae, ILaliostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laliostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129010;

    /// <inheritdoc />
    public virtual string GenusName => "Laliostoma";

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
