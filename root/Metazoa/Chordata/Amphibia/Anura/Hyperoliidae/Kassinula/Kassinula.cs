using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Kassinula;

/// <summary>
/// Abstract class for Kassinula (genus).
/// NCBI TaxId: 2767800
/// </summary>
public abstract class Kassinula : Hyperoliidae, IKassinula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kassinula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767800;

    /// <inheritdoc />
    public virtual string GenusName => "Kassinula";

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
