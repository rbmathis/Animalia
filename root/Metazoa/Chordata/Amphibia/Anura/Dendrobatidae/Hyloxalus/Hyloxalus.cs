using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Hyloxalus;

/// <summary>
/// Abstract class for Hyloxalus (genus).
/// NCBI TaxId: 490056
/// </summary>
public abstract class Hyloxalus : Dendrobatidae, IHyloxalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyloxalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490056;

    /// <inheritdoc />
    public virtual string GenusName => "Hyloxalus";

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
