using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Pseudocheiridae;

/// <summary>
/// Abstract class for Pseudocheiridae (family).
/// NCBI TaxId: 37889
/// </summary>
public abstract class Pseudocheiridae : Diprotodontia, IPseudocheiridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocheiridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37889;

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
