using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Trogonophidae;

/// <summary>
/// Abstract class for Trogonophidae (family).
/// NCBI TaxId: 94418
/// </summary>
public abstract class Trogonophidae : Squamata, ITrogonophidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trogonophidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94418;

    /// <inheritdoc />
    public virtual string FamilyName => "Canidae";

    /// <inheritdoc />
    public virtual string[] FamilyCharacteristics => new[]
    {
        "Long muzzle",
        "Non-retractable claws",
        "Digitigrade stance",
        "Bushy tail",
        "Social behavior common"
    };

    /// <inheritdoc />
    public virtual bool HasNonRetractableClaws => true;

    /// <inheritdoc />
    public virtual bool IsDigitigrade => true;

    /// <inheritdoc />
    public virtual int FrontToeCount => 5;

    /// <inheritdoc />
    public virtual int HindToeCount => 4;

    /// <inheritdoc />
    public virtual string[] CommunicationMethods => new[]
    {
        "Vocalizations (howling, barking, whimpering)",
        "Body language",
        "Scent marking",
        "Facial expressions"
    };

}
