using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Chrysoblephus;

/// <summary>
/// Abstract class for Chrysoblephus (genus).
/// NCBI TaxId: 119705
/// </summary>
public abstract class Chrysoblephus : Sparidae, IChrysoblephus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysoblephus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119705;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysoblephus";

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
