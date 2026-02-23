using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Retropinnidae;

/// <summary>
/// Abstract class for Retropinnidae (family).
/// NCBI TaxId: 130260
/// </summary>
public abstract class Retropinnidae : Osmeriformes, IRetropinnidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Retropinnidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 130260;

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
