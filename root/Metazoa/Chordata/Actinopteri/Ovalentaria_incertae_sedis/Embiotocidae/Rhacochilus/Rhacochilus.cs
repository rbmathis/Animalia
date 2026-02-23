using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Rhacochilus;

/// <summary>
/// Abstract class for Rhacochilus (genus).
/// NCBI TaxId: 100201
/// </summary>
public abstract class Rhacochilus : Embiotocidae, IRhacochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhacochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100201;

    /// <inheritdoc />
    public virtual string GenusName => "Rhacochilus";

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
