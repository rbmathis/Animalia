using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Pinguipedidae.Kochichthys;

/// <summary>
/// Abstract class for Kochichthys (genus).
/// NCBI TaxId: 2650379
/// </summary>
public abstract class Kochichthys : Pinguipedidae, IKochichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kochichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650379;

    /// <inheritdoc />
    public virtual string GenusName => "Kochichthys";

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
