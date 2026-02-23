using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Ceratopipra;

/// <summary>
/// Abstract class for Ceratopipra (genus).
/// NCBI TaxId: 1356508
/// </summary>
public abstract class Ceratopipra : Pipridae, ICeratopipra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratopipra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1356508;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratopipra";

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
