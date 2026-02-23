using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Heterixalus;

/// <summary>
/// Abstract class for Heterixalus (genus).
/// NCBI TaxId: 39597
/// </summary>
public abstract class Heterixalus : Hyperoliidae, IHeterixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39597;

    /// <inheritdoc />
    public virtual string GenusName => "Heterixalus";

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
