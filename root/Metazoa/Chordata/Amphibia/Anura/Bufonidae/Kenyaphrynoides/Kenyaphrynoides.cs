using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Kenyaphrynoides;

/// <summary>
/// Abstract class for Kenyaphrynoides (genus).
/// NCBI TaxId: 3095322
/// </summary>
public abstract class Kenyaphrynoides : Bufonidae, IKenyaphrynoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kenyaphrynoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095322;

    /// <inheritdoc />
    public virtual string GenusName => "Kenyaphrynoides";

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
