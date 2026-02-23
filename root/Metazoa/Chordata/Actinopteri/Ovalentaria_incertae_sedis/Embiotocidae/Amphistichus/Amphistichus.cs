using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Amphistichus;

/// <summary>
/// Abstract class for Amphistichus (genus).
/// NCBI TaxId: 51787
/// </summary>
public abstract class Amphistichus : Embiotocidae, IAmphistichus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphistichus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51787;

    /// <inheritdoc />
    public virtual string GenusName => "Amphistichus";

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
