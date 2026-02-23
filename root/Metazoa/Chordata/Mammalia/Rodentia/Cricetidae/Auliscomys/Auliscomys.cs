using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Auliscomys;

/// <summary>
/// Abstract class for Auliscomys (genus).
/// NCBI TaxId: 29103
/// </summary>
public abstract class Auliscomys : Cricetidae, IAuliscomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auliscomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29103;

    /// <inheritdoc />
    public virtual string GenusName => "Auliscomys";

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
