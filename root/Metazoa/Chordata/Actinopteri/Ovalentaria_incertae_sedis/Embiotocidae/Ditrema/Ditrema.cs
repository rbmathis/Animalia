using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Ditrema;

/// <summary>
/// Abstract class for Ditrema (genus).
/// NCBI TaxId: 83877
/// </summary>
public abstract class Ditrema : Embiotocidae, IDitrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ditrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83877;

    /// <inheritdoc />
    public virtual string GenusName => "Ditrema";

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
