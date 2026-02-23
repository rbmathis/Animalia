using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

/// <summary>
/// Abstract class for Phasianidae (family).
/// NCBI TaxId: 9005
/// </summary>
public abstract class Phasianidae : Galliformes, IPhasianidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phasianidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9005;

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
