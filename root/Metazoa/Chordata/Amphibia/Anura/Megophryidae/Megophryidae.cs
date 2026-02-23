using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

/// <summary>
/// Abstract class for Megophryidae (family).
/// NCBI TaxId: 161696
/// </summary>
public abstract class Megophryidae : Anura, IMegophryidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megophryidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161696;

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
