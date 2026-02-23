using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Thylacinidae;

/// <summary>
/// Abstract class for Thylacinidae (family).
/// NCBI TaxId: 9273
/// </summary>
public abstract class Thylacinidae : Dasyuromorphia, IThylacinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thylacinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9273;

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
