using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Rastrelliger;

/// <summary>
/// Abstract class for Rastrelliger (genus).
/// NCBI TaxId: 70445
/// </summary>
public abstract class Rastrelliger : Scombridae, IRastrelliger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rastrelliger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70445;

    /// <inheritdoc />
    public virtual string GenusName => "Rastrelliger";

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
