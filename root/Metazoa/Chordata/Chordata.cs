using AnimalKingdom.root.Metazoa;

namespace AnimalKingdom.root.Metazoa.Chordata;

/// <summary>
/// Abstract class for Chordata (phylum).
/// NCBI TaxId: 7711
/// </summary>
public abstract class Chordata : Metazoa, IChordata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chordata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "phylum";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7711;

    /// <inheritdoc />
    public virtual string PhylumName => "Chordata";

    /// <inheritdoc />
    public virtual string[] PhylumCharacteristics => new[]
    {
        "Notochord present at some stage",
        "Dorsal hollow nerve cord",
        "Pharyngeal slits",
        "Post-anal tail",
        "Endostyle or thyroid gland"
    };

    /// <inheritdoc />
    public virtual bool HasNotochord => true;

    /// <inheritdoc />
    public virtual bool NotochordPersistsInAdult => false;

    /// <inheritdoc />
    public virtual string? NotochordReplacement => "Vertebral column";

    /// <inheritdoc />
    public virtual bool HasVertebralColumn => true;

    /// <inheritdoc />
    public virtual string SkeletalType => "Endoskeleton";

    /// <inheritdoc />
    public virtual bool HasCranium => true;

    /// <inheritdoc />
    public virtual string VertebraeCount => "Variable";

}
