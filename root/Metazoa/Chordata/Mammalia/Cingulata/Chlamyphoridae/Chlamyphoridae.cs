using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

/// <summary>
/// Abstract class for Chlamyphoridae (family).
/// NCBI TaxId: 1811493
/// </summary>
public abstract class Chlamyphoridae : Cingulata, IChlamyphoridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamyphoridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1811493;

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
