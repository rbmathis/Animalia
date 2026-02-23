using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Altiphrynoides;

/// <summary>
/// Abstract class for Altiphrynoides (genus).
/// NCBI TaxId: 1539428
/// </summary>
public abstract class Altiphrynoides : Bufonidae, IAltiphrynoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Altiphrynoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539428;

    /// <inheritdoc />
    public virtual string GenusName => "Altiphrynoides";

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
