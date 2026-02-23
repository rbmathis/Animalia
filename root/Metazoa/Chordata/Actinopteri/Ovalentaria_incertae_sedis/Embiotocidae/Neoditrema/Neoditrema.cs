using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Neoditrema;

/// <summary>
/// Abstract class for Neoditrema (genus).
/// NCBI TaxId: 100197
/// </summary>
public abstract class Neoditrema : Embiotocidae, INeoditrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoditrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100197;

    /// <inheritdoc />
    public virtual string GenusName => "Neoditrema";

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
