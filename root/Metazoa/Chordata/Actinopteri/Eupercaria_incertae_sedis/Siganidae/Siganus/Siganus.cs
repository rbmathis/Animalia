using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.Siganus;

/// <summary>
/// Abstract class for Siganus (genus).
/// NCBI TaxId: 75041
/// </summary>
public abstract class Siganus : Siganidae, ISiganus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siganus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75041;

    /// <inheritdoc />
    public virtual string GenusName => "Siganus";

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
