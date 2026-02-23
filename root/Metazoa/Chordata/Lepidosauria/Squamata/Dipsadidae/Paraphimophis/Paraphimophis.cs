using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Paraphimophis;

/// <summary>
/// Abstract class for Paraphimophis (genus).
/// NCBI TaxId: 1391624
/// </summary>
public abstract class Paraphimophis : Dipsadidae, IParaphimophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraphimophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1391624;

    /// <inheritdoc />
    public virtual string GenusName => "Paraphimophis";

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
