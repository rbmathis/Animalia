using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Metabolus;

/// <summary>
/// Abstract class for Metabolus (genus).
/// NCBI TaxId: 338453
/// </summary>
public abstract class Metabolus : Monarchidae, IMetabolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metabolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338453;

    /// <inheritdoc />
    public virtual string GenusName => "Metabolus";

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
