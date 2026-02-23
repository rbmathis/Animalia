using AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Dromaiidae;

/// <summary>
/// Abstract class for Dromaiidae (family).
/// NCBI TaxId: 8788
/// </summary>
public abstract class Dromaiidae : Casuariiformes, IDromaiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dromaiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8788;

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
