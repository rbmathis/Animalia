using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Heleophrynidae.Hadromophryne;

/// <summary>
/// Abstract class for Hadromophryne (genus).
/// NCBI TaxId: 1005959
/// </summary>
public abstract class Hadromophryne : Heleophrynidae, IHadromophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hadromophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1005959;

    /// <inheritdoc />
    public virtual string GenusName => "Hadromophryne";

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
