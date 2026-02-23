using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nimbaphrynoides;

/// <summary>
/// Abstract class for Nimbaphrynoides (genus).
/// NCBI TaxId: 717467
/// </summary>
public abstract class Nimbaphrynoides : Bufonidae, INimbaphrynoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nimbaphrynoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 717467;

    /// <inheritdoc />
    public virtual string GenusName => "Nimbaphrynoides";

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
