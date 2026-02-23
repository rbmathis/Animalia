using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Surdisorex;

/// <summary>
/// Abstract class for Surdisorex (genus).
/// NCBI TaxId: 2094177
/// </summary>
public abstract class Surdisorex : Soricidae, ISurdisorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Surdisorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2094177;

    /// <inheritdoc />
    public virtual string GenusName => "Surdisorex";

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
