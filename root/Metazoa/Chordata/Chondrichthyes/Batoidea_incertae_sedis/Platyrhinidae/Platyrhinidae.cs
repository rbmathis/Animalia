using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Batoidea_incertae_sedis.Platyrhinidae;

/// <summary>
/// Abstract class for Platyrhinidae (family).
/// NCBI TaxId: 117848
/// </summary>
public abstract class Platyrhinidae : Batoidea_incertae_sedis, IPlatyrhinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyrhinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "family";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117848;

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
