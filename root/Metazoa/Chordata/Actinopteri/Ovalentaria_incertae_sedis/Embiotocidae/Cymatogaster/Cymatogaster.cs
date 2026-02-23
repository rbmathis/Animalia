using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Cymatogaster;

/// <summary>
/// Abstract class for Cymatogaster (genus).
/// NCBI TaxId: 50792
/// </summary>
public abstract class Cymatogaster : Embiotocidae, ICymatogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymatogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50792;

    /// <inheritdoc />
    public virtual string GenusName => "Cymatogaster";

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
