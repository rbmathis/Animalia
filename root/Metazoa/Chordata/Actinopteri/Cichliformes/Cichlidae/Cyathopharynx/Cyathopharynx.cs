using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyathopharynx;

/// <summary>
/// Abstract class for Cyathopharynx (genus).
/// NCBI TaxId: 27740
/// </summary>
public abstract class Cyathopharynx : Cichlidae, ICyathopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyathopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27740;

    /// <inheritdoc />
    public virtual string GenusName => "Cyathopharynx";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
