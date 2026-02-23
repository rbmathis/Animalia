using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paragunnellichthys;

/// <summary>
/// Abstract class for Paragunnellichthys (genus).
/// NCBI TaxId: 2696270
/// </summary>
public abstract class Paragunnellichthys : Gobiidae, IParagunnellichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paragunnellichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696270;

    /// <inheritdoc />
    public virtual string GenusName => "Paragunnellichthys";

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
