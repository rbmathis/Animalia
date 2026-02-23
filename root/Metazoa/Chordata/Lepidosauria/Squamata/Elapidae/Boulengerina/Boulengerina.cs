using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Boulengerina;

/// <summary>
/// Abstract class for Boulengerina (genus).
/// NCBI TaxId: 8608
/// </summary>
public abstract class Boulengerina : Elapidae, IBoulengerina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boulengerina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8608;

    /// <inheritdoc />
    public virtual string GenusName => "Boulengerina";

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
