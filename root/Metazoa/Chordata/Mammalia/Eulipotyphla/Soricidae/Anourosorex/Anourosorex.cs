using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Anourosorex;

/// <summary>
/// Abstract class for Anourosorex (genus).
/// NCBI TaxId: 127559
/// </summary>
public abstract class Anourosorex : Soricidae, IAnourosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anourosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127559;

    /// <inheritdoc />
    public virtual string GenusName => "Anourosorex";

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
