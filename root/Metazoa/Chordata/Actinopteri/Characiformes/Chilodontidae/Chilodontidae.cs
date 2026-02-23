using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae;

/// <summary>
/// Abstract class for Chilodontidae (family).
/// NCBI TaxId: 42619
/// </summary>
public abstract class Chilodontidae : Characiformes, IChilodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42619;

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
