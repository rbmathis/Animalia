using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Brookesia;

/// <summary>
/// Abstract class for Brookesia (genus).
/// NCBI TaxId: 91903
/// </summary>
public abstract class Brookesia : Chamaeleonidae, IBrookesia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brookesia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91903;

    /// <inheritdoc />
    public virtual string GenusName => "Brookesia";

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
