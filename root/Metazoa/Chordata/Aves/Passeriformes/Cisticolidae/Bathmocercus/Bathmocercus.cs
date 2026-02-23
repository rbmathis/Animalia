using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Bathmocercus;

/// <summary>
/// Abstract class for Bathmocercus (genus).
/// NCBI TaxId: 330752
/// </summary>
public abstract class Bathmocercus : Cisticolidae, IBathmocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathmocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330752;

    /// <inheritdoc />
    public virtual string GenusName => "Bathmocercus";

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
