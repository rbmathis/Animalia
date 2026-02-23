using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae;

/// <summary>
/// Abstract class for Megalaimidae (family).
/// NCBI TaxId: 91771
/// </summary>
public abstract class Megalaimidae : Piciformes, IMegalaimidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalaimidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91771;

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
