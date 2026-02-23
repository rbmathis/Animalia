using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Excidobates;

/// <summary>
/// Abstract class for Excidobates (genus).
/// NCBI TaxId: 1004470
/// </summary>
public abstract class Excidobates : Dendrobatidae, IExcidobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Excidobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1004470;

    /// <inheritdoc />
    public virtual string GenusName => "Excidobates";

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
